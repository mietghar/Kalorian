namespace Kalorian.Helper.FilesOperations
{
    public class FileProviderFactory
    {
        public virtual IFileProvider GetFileProvider(EFileType fileType)
        {
            IFileProvider _fileProvider = null;
            switch (fileType)
            {
                case EFileType.Product:
                    _fileProvider = new ProductFileProvider();
                    break;
                case EFileType.Meal:
                    _fileProvider = new MealFileProvider();
                    break;
            }
            return _fileProvider;
        }
    }
}
