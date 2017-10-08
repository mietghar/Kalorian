using Kalorian.Common.Utility.Common;
using Kalorian.Helper.FilesOperations;
using Kalorian.Product.Interface;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Kalorian.DAL.Entity;
using System;

namespace Kalorian.Product.Presenter
{
    public class ClP_Product
    {
        private readonly I_ProductView View;
        private IFileProvider ProductFileProvider = new FileProviderFactory().GetFileProvider(EFileType.Product);

        public ClP_Product(I_ProductView view)
        {
            View = view;
        }

        internal bool SaveNewProduct()
        {
            try
            {
                var _combinedPath = ProductFileProvider.GetFileData().Path;
                List<IIdentifiable> _allProductsIds = new List<IIdentifiable>();
                //stworzenie nowego obiektu produktu
                ProductDO _product = new ProductDO
                {
                    ProductName = View.ProductName,
                    Carbo = View.Carbo,
                    Fat = View.Fat,
                    KcalPer100Gramm = View.KcalPerGramm,
                    Salt = View.Salt,
                    Whey = View.Whey,
                    Id = 1
                };
                var _serializedProduct = JsonConvert.SerializeObject(_product);
                if (!ProductFileProvider.CheckIfFileExists())
                {
                    using (var _file = File.CreateText(_combinedPath))
                    {
                        _file.WriteLine("[");
                        _file.WriteLine(_serializedProduct);
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
                    _product.Id = _deserializedFile.Select(x => x.Id).Max() + 1;
                    var _lastIndexOfProductList = _linesToKeep.Count - 1;
                    _linesToKeep[_lastIndexOfProductList] = string.Format("{0},", _linesToKeep[_lastIndexOfProductList]);
                    _linesToKeep.Add(JsonConvert.SerializeObject(_product));
                    _linesToKeep.Add("]");
                    File.WriteAllLines(_tempFilePath, _linesToKeep);
                    File.Delete(_combinedPath);
                    File.Move(_tempFilePath, _combinedPath);                    
                }

                return true;
            }
            catch { return false; }            
        }
    }
}
