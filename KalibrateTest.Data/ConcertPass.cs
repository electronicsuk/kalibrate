using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.BusinessLayer
{
    public class ConcertPass : IQualityDeteriateStratergy
    {
        public string QualityControl(string name, int sellIn, int quality)
        {
            sellIn -= 1;
            if (sellIn <= 5 && sellIn >0)
            {
                quality += 3;                
            }
            else if(sellIn <=0)
            {
                quality = 0;
            }
            else if(sellIn <=10)
            {
                quality += 2;                
            }
            quality = BaseRules.ApplyBusinessLogic(quality);            
            return name + " " + sellIn + " " + quality;
        }
    }
}
