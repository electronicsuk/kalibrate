using KalibrateTest.BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalibrateTest.BusinessLayer.Objects;
namespace KalibrateTest.Services
{
    public  class ProductService
    {
        public List<string> ProductsLoadFromTextFile(string csvData)
        {
            List<string> products = new List<string>();
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    IProduct product = new Product();
                    string[] rowData = row.Split(' ');

                    int sellInFieldIndex = 0;

                    if (IsNumberic(rowData[1]))
                    {
                        rowData[0] = rowData[0];
                        sellInFieldIndex = 1;
                    }
                    else
                    {
                        rowData[0] += " " + rowData[1];
                        sellInFieldIndex = 2;
                    }

                    ProductFactory factory = new ProductFactory();                    
                    if (product != null)
                    {
                        IQualityDeteriateStratergy currentProduct = factory.CreateQualityDeteriateStratergy(rowData[0].ToLower());
                        product.Name = rowData[0];
                        int sellInValue = 0;
                        int.TryParse(rowData[sellInFieldIndex], out sellInValue);
                        
                        product.SellIn = sellInValue;
                        product.SetStratergy(currentProduct);

                        int qualityValue = 0;
                        int.TryParse(rowData[++sellInFieldIndex], out qualityValue);
                        product.Quality = qualityValue;                        
                        products.Add(product.QualityControl(product.Name,product.SellIn,product.Quality));
                    }
                   
                }
            }

            return products;
        }

        public bool IsNumberic(string s) {
            int n;
            bool isNumeric = int.TryParse(s, out n);
            return isNumeric;
        }
    }
}
