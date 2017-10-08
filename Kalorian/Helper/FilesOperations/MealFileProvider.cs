namespace Kalorian.Helper.FilesOperations
{
    public class MealFileProvider : FileProvider
    {
        private new string FileName => "Meals";

        public MealFileProvider()
        {
            base.FileName = this.FileName;
        }
    }
}
