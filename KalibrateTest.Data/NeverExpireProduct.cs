using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.BusinessLayer
{
    public class LegendaryProduct : IQualityDeteriateStratergy
    {        
        public string QualityControl(string name, int sellIn, int quality)
        {
            return name + " " + sellIn + " " + quality;    
        }
    }
}
