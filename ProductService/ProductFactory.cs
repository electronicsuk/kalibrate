using KalibrateTest.BusinessLayer;
namespace KalibrateTest.Services
{
    internal class ProductFactory :IProductFactory
    {
       public IQualityDeteriateStratergy CreateQualityDeteriateStratergy(string type)
       {
            IQualityDeteriateStratergy product = null;
            switch (type)
            {
                case "aged brie":
                    product = new IncreaseQualityProduct();
                    break;
                case "normal item":
                    product = new NormalProduct();
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
            return product;
        }
    }
}