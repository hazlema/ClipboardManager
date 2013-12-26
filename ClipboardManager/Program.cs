using System;
using System.IO;
using System.Drawing;

namespace ClipboardManager
{
    static class Program
    {
        [STAThread]
        static void Main(string[] Args)
        {
            Arguments CommandLine = new Arguments(Args);

            if (CommandLine["cmd"] != null)
            {
                switch (CommandLine["cmd"])
                {
                    case "copy":
                        if (CommandLine["text"] != null)
                        {
                            Clip.Clear();
                            Clip.Copy(CommandLine["text"]);
                        }
                        else
                        {
                            if (CommandLine["file"] != null)
                            {
                                if (File.Exists(CommandLine["file"]))
                                {
                                    string ext = Path.GetExtension(CommandLine["file"]);
                                    if (ext.Contains(".gif") || ext.Contains(".jpg") || ext.Contains(".png") || ext.Contains(".bmp"))
                                    {
                                        using (Image img = Image.FromFile(CommandLine["file"]))
                                        {
                                            Clip.Clear();
                                            Clip.Copy(img);
                                        }
                                    } else {
                                        Clip.Clear();
                                        Clip.Copy(File.ReadAllText(CommandLine["file"]));
                                    }
                                }
                            }
                        }
                        break;

                    case "paste":
                        Console.Write(Clip.Paste());
                        break;

                    case "clear": 
                        Clip.Clear();
                        break;
                }
            }

            if (CommandLine["help"] != null)
            {
                Console.WriteLine("ClipboardManager written specificly for Brackets (http://brackets.io/)");
                Console.WriteLine("Written by: Matthew Hazlett (hazlema@gmail.com)");
                Console.WriteLine();
                Console.WriteLine("Due to commandline limitations it is always preferable to copy");
                Console.WriteLine("from a -file and not the commandline.");
                Console.WriteLine();
                Console.WriteLine("ClipboardManager -cmd copy -file readme.txt");
                Console.WriteLine("ClipboardManager -cmd copy -file image.png (.gif or .bmp or .jpg)");
                Console.WriteLine("ClipboardManager -cmd copy -text \"This is the text to copy\"");
                Console.WriteLine("ClipboardManager -cmd paste");
                Console.WriteLine("ClipboardManager -cmd clear");
            }
        }
    }
}
