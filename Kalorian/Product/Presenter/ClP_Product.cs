using Kalorian.DAL.Entity;
using Kalorian.Product.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kalorian.Product.Presenter
{
    class Cl_Id
    {
        public int Id { get; set; }
    }

    public class ClP_Product
    {
        private readonly I_ProductView vrcView;

        public ClP_Product(I_ProductView vrpView)
        {
            vrcView = vrpView;
        }

        internal void SaveNewProduct()
        {
            var _path = Environment.CurrentDirectory;
            var _filename = "Products.dat";
            var _combinedPath = string.Format("{0}\\{1}", _path, _filename);
            List<Cl_Id> _AllProductsIds = new List<Cl_Id>();
            //stworzenie nowego obiektu produktu
            Cl_Product vrlProduct = new Cl_Product
            {
                ProductName = vrcView.ProductName,
                Carbo = vrcView.Carbo,
                Fat = vrcView.Fat,
                KcalPerGramm = vrcView.KcalPerGramm,
                Salt = vrcView.Salt,
                Whey = vrcView.Whey,
                Id = 1
            };
            var vrlSerializedProduct = JsonConvert.SerializeObject(vrlProduct);
            if (!File.Exists(_combinedPath))
            {
                using (var tw = File.CreateText(_combinedPath))
                {
                    tw.WriteLine("[");
                    tw.WriteLine(vrlSerializedProduct);
                    tw.WriteLine("]");
                    tw.Close();
                }
            }
            else
            {
                var vrlAllFile = File.ReadAllText(_combinedPath);
                var vrlDeserializedFile = JsonConvert.DeserializeObject<List<Cl_Id>>(vrlAllFile);
                var vrlMaxId = vrlDeserializedFile.Select(x => x.Id).Max();

                string _tempFilePath = Path.GetTempFileName();
                var _linesToKeep = File.ReadLines(_combinedPath).Where(x => x != "]");
                List<string> aaa = _linesToKeep.ToList();
                vrlProduct.Id = vrlMaxId + 1;
                var _lastIndexOfProductList = aaa.Count - 1;
                aaa[_lastIndexOfProductList] = string.Format("{0},", aaa[_lastIndexOfProductList]);
                aaa.Add(JsonConvert.SerializeObject(vrlProduct));
                aaa.Add("]");
                File.WriteAllLines(_tempFilePath, aaa);
                File.Delete(_combinedPath);
                File.Move(_tempFilePath, _combinedPath);
            }
        }
    }
}
