using Kalorian.Meal.Interface;
using Kalorian.Helper.FilesOperations;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using Kalorian.Common.Utility.Common;
using Kalorian.DAL.Entity;
using System.IO;
using System.Linq;

namespace Kalorian.Meal.Presenter
{
    public class ClP_Meal
    {
        I_MealView Meal;
        IFileProvider MealFileProvider = new FileProviderFactory().GetFileProvider(EFileType.Meal);
        IFileProvider ProductFileProvider = new FileProviderFactory().GetFileProvider(EFileType.Product);

        public ClP_Meal(I_MealView meal)
        {
            Meal = meal;
        }

        internal bool SaveNewMeal()
        {
            if (Meal.MealTimeStamp == null || Meal.ProductId == 0 || Meal.Weight == decimal.Zero) return false;

            try
            {
                var _combinedPath = MealFileProvider.GetFileData().Path;
                List<IIdentifiable> _allMealsIds = new List<IIdentifiable>();
                //stworzeni nowego obiektu posilku
                MealDO _meal = new MealDO
                {
                    Id = 1,
                    MealTimeStamp = Meal.MealTimeStamp,
                    ProductId = Meal.ProductId,
                    Weight = Meal.Weight
                };

                var _serializedMeal = JsonConvert.SerializeObject(_meal);
                if (!MealFileProvider.CheckIfFileExists())
                {
                    using (var _file = File.CreateText(_combinedPath))
                    {
                        _file.WriteLine("[");
                        _file.WriteLine(_serializedMeal);
                        _file.WriteLine("]");
                        _file.Close();
                    }
                }
                else
                {
                    var _allFile = File.ReadAllText(_combinedPath);
                    var _deserializedFile = JsonConvert.DeserializeObject<List<Identifiable>>(_allFile);

                    var _tempFilePath = Path.GetTempFileName();
                    var _linesToKeep = File.ReadLines(_combinedPath).Where(x => x != "]").ToList();
                    _meal.Id = _deserializedFile.Select(x => x.Id).Max() + 1;
                    var _lastIndexOfMealList = _linesToKeep.Count - 1;
                    _linesToKeep[_lastIndexOfMealList] = string.Format("{0},", _linesToKeep[_lastIndexOfMealList]);
                    _linesToKeep.Add(JsonConvert.SerializeObject(_meal));
                    _linesToKeep.Add("]");
                    File.WriteAllLines(_tempFilePath, _linesToKeep);
                    File.Delete(_combinedPath);
                    File.Move(_tempFilePath, _combinedPath);
                }

                return true;
            }
            catch { return false; }
        }

        internal IEnumerable<ProductDO> PopulateProductList()
        {
            try
            {
                if (!ProductFileProvider.CheckIfFileExists())
                {
                    MessageBox.Show("Brak pliku z produktami, produkty nie zostały dodane lub plik został usunięty");
                    return null;
                }
                else
                    return GetProductList().OrderBy(x => x.ProductName);
            }
            catch { return null; }
        }

        private IEnumerable<ProductDO> GetProductList() =>
            JsonConvert.DeserializeObject<List<ProductDO>>(ProductFileProvider.GetFileData().Content);
    }
}
