using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.BusinessLayer
{
    public class IncreaseQualityProduct : IQualityDeteriateStratergy
    {       
        public string QualityControl(string name, int sellIn, int quality)
        {
             int factor = sellIn * -1;
            //increase quality the older it gets  
               sellIn -= 1;          
            quality += (factor)*-1;
            quality = BaseRules.ApplyBusinessLogic(quality);
            return name + " " + sellIn + " " + quality;
        }
    }   

}
