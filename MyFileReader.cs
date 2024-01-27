using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ShortcutFolder
{
    sealed class MyFileReader
    {
        int _pointer = 0;
        int _blockPointer = 0;
        string _fileContent;
        List<LabelLine> lLines = new List<LabelLine>();

        public MyFileReader(string fileContent)
        { 
            foreach(var chr in fileContent)
            {
                if(chr == '\n' || chr == '\r'  || chr == '\t') { continue; }
                _fileContent += chr;
            }
            Console.WriteLine(_fileContent);
            if(fileContent != "") Read();
        }

        void Read()
        {
            while (_pointer < _fileContent.Length)
            {
                lLines.Add(NextBlock());
            }
        }
        LabelLine NextBlockValues(string blockContent)
        {
            string nameGeter = "_name_=";
            string adressGeter = "_adress_=";
            string viaGeter = "_via_=";
            string imgAdressGeter = "_imgAdress_=";

            string readedName, readedAdress, readedVia, readedImgAdress;

            try
            {
                int start = blockContent.IndexOf(nameGeter) + nameGeter.Length;
                int end = blockContent.IndexOf(";");
                readedName = blockContent.Substring(start, end - start);
                _blockPointer = end + 1;

                start = blockContent.IndexOf(adressGeter) + adressGeter.Length;
                end = blockContent.IndexOf(";", _blockPointer);
                readedAdress = blockContent.Substring(start, end - start);
                _blockPointer = end + 1;

                start = blockContent.IndexOf(viaGeter) + viaGeter.Length;
                end = blockContent.IndexOf(";", _blockPointer);
                readedVia = blockContent.Substring(start, end - start);
                _blockPointer = end + 1;

                start = blockContent.IndexOf(imgAdressGeter) + imgAdressGeter.Length;
                end = blockContent.IndexOf(";", _blockPointer);
                readedImgAdress = blockContent.Substring(start, end - start);
                _blockPointer = end + 1;
                return new LabelLine(readedName, readedAdress, readedVia, readedImgAdress);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show($"Cannot read following shortcut:\n\n{blockContent}\n\nCreate clear shortcut where error occurred [Y]\nOpen save file and fix manually [N]",
                    "Shortcut Folder Error Handler", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes) { return new LabelLine(); }

                Process.Start(Form1.myFile, @"C:\Windows\System32\notepad.exe");
                Form1.Instance.Close();
                return new LabelLine("ERROR", "ERROR", "ERROR", "ERROR");
            }
        }
        LabelLine NextBlock()
        {
            var start = _fileContent.IndexOf('{', _pointer) + 1;
            var end = _fileContent.IndexOf('}', _pointer);
            _pointer = end + 1;
            return NextBlockValues(_fileContent.Substring(start, end - start));
        }
        public List<LabelLine> GetLabelLines() => lLines;
    }
}