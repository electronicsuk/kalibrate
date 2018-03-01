using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.Data
{
    public class IncreaseQualityProduct :Product
    {       
        public override string QualityControl()
        {           
          
            int factor = SellIn * -1;
            //increase quality the older it gets  
               SellIn -= 1;          
            Quality += (factor)*-1;
            return base.Print();
        } 

    }   

}
