Clipboard Manager
=================
Matthew Hazlett (<hazlema@gmail.com>)

Requires .NET 3.5+

Copy text to the clipboard.
*This is the first part of a plugin for Brackets.io* (<http://braackets.io>)

**This is a commandline utility**

***Commandline***

- ClipboardManager -cmd paste
- ClipboardManager -cmd copy -text "I am a block of text"
- ClipboardManager -cmd copy -file readme.txt
- ClipboardManager -cmd copy -file image.gif (Supports Gif, Jpg, Bmp,Png)
- ClipboardManager -cmd clear

***Note***

When you copy using -file, it dosn't copy the physical file object.  It formats the files contents for the clipboard and copies that to the clipboard.  Same with images.

