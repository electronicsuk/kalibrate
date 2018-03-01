using KalibrateTest.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Product product = null;
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

                    switch(rowData[0].ToLower())
                    {
                        case "aged brie":
                            product = new IncreaseQualityProduct();
                        break;
                        case "normal item":
                            product = new Product();
                       break;
                       case "sulfuras":
                            product = new LegendaryProduct();
                       break;
                       case "backstage passes":
                            product = new ConcertPass();
                       break;
                        case "conjured":
                            product = new ConjuredProduct();
                            break;
                        default:
                            product = new UnsupportedProduct();
                            break;
                    }

                    if (product != null)
                    {
                        product.Name = rowData[0];
                        int sellInValue = 0;
                        int.TryParse(rowData[sellInFieldIndex], out sellInValue);
                        
                        product.SellIn = sellInValue;

                        int qualityValue = 0;
                        int.TryParse(rowData[++sellInFieldIndex], out qualityValue);
                        product.Quality = qualityValue;                        
                        products.Add(product.QualityControl());
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
