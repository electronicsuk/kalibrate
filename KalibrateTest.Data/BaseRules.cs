using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.BusinessLayer
{
    public static class BaseRules
    {
        public static int ApplyBusinessLogic(int quality)
        {
            if (quality <= 0) { quality = 0; }
            else if (quality > 50) { quality = 50; }
            return quality;
        }
    }
}
