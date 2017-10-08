namespace Kalorian.Helper.FilesOperations
{
    public class ProductFileProvider : FileProvider
    {
        private new string FileName => "Products";

        public ProductFileProvider()
        {
            base.FileName = this.FileName;
        }
    }
}
