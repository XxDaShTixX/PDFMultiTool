using System.IO;

namespace PDFMultiTool.Models
{
    internal class FileModel
    {
        public string FullPath { get; set; }
        public string FileName { get; set; }

        public FileModel(string fullPath)
        {
            FullPath = fullPath;
            FileName = Path.GetFileName(fullPath);
        }

        public override string ToString()
        {
            return FileName;
        }
    }
}
