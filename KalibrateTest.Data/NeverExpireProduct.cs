using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.Data
{
    public class LegendaryProduct : Product
    {
        public override string QualityControl()
        {
            return base.Name + " " + base.SellIn + " " + Quality;    
        }
    }
}
