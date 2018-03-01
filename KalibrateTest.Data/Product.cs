using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.Data
{
    public class Product :IProduct
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public virtual string QualityControl()
        {            
            SellIn -= 1;

            if (SellIn <= 0)
            {
                Quality -= 2;
            }
            else
            {
                Quality -=1;
            }

            return Print();
        } 

        public virtual string Print()
        {
            ApplyBusinessLogic();
            return Name + " " + SellIn + " " + Quality;
        }

        public virtual void ApplyBusinessLogic()
        {
            if(Quality <= 0) { Quality = 0; }
            else if(Quality > 50 ) { Quality = 50; }
        }

    }   

}
