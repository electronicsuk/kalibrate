using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.Data
{
    public class ConcertPass : Product
    {
        public override string QualityControl()
        {
            if(SellIn <= 5 && SellIn >0)
            {
                Quality += 3;
                SellIn -= 1;
            }
            else if(SellIn <=0)
            {
                base.QualityControl();
            }
            else if(SellIn <=10)
            {
                Quality += 2;
                SellIn -= 1;
            }
           
            return base.Print();
        }
    }
}
