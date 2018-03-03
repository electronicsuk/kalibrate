using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KalibrateTest.BusinessLayer;

namespace KalibrateTest.BusinessLayer.Objects
{
    public class Product : IProduct, IQualityDeteriateStratergy
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public IQualityDeteriateStratergy stratergy { get; private set; }
                
        public void SetStratergy(IQualityDeteriateStratergy stratergy)
        {
            this.stratergy = stratergy;
        }

        public string QualityControl(string name, int sellIn, int quality)
        {
            return stratergy.QualityControl(name,sellIn,quality);
        }        
    }
}
