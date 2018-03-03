using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.BusinessLayer
{
    public class ConjuredProduct : IQualityDeteriateStratergy
    {
        public string QualityControl(string name, int sellIn, int quality)
        {
              sellIn -= 1;
            quality -= 2;
            if (sellIn <= 0)
            {
                quality -= 2;
            }
            else
            {
                quality -= 1;
            }

            quality = BaseRules.ApplyBusinessLogic(quality);
            return name + " " + sellIn + " " + quality;
        }
    }   

}
