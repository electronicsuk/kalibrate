using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.Data
{
    public class ConjuredProduct :Product
    {       
        public override string QualityControl()
        {            
            SellIn -= 1;
            Quality -= 2;
            if (SellIn <= 0)
            {
                Quality -= 2;
            }
            else
            {
                Quality -= 1;
            }

            return Print();
        } 

        

    }   

}
