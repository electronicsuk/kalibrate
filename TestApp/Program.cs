using KalibrateTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService srv = new ProductService();
            string csvPath = AppDomain.CurrentDomain.BaseDirectory +"data.csv";
            string csvData = System.IO.File.ReadAllText(csvPath);
            foreach (string s in srv.ProductsLoadFromTextFile(csvData))
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
