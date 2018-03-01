using KalibrateTest.Data;

namespace KalibrateTest.Services
{
    public class UnsupportedProduct : Product
    {
        public override string Print()
        {
            return "NO SUCH ITEM";
        }
    }
}