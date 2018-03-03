
namespace KalibrateTest.BusinessLayer
{
    public class UnsupportedProduct : IQualityDeteriateStratergy
    {
        public string QualityControl(string name, int sellIn, int quality)
        {
            return "NO SUCH ITEM";
        }
    }
}