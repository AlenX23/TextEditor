using System;
using System.IO;

namespace WindowsFormsApp2
{
    class FileData
    {
        public FileInfo file;
        public string Content;
        public bool IsNotSaveOnce = true;

        public event EventHandler<string> DidUpdateContent;
        public FileData()
        {
            file = new FileInfo("NewFile");
            Content = "";
        }

        public FileData(string filename)
        {
            file = new FileInfo(filename);
            Content = file.OpenText().ReadToEnd();
        }
    }
}
