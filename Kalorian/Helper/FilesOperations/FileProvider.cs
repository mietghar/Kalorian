using System;
using System.IO;

namespace Kalorian.Helper.FilesOperations
{
    public abstract class FileProvider : IFileProvider
    {
        protected string FileName { get; set; }

        protected string Path => string.Format("{0}\\{1}.{2}", Environment.CurrentDirectory, FileName, "dat");

        public bool CheckIfFileExists() => File.Exists(Path);

        public IFileData GetFileData()
        {
            try
            {
                return new FileData
                {
                    Path = Path,
                    Content = File.ReadAllText(Path)
                };
            }
            catch
            {
                return new FileData
                {
                    Path = Path,
                    Content = string.Empty
                };
            }
        }
    }
}
