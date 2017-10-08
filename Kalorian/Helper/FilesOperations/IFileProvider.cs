using System.Collections.Generic;

namespace Kalorian.Helper.FilesOperations
{
    public interface IFileProvider
    {
        bool CheckIfFileExists();
        IFileData GetFileData();
    }
}
