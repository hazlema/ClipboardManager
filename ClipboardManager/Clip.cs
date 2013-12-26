using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClipboardManager
{
    static class Clip
    {
        public static void Copy(string data)
        {
            Clipboard.SetText(data);
        }
        public static void Copy(Image data)
        {
            Clipboard.SetImage(data);
        }
        public static string Paste()
        {
            return Clipboard.GetText();
        }
        public static void Clear()
        {
            Clipboard.Clear();
        }
    }
}
