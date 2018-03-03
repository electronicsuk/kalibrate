using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalibrateTest.BusinessLayer
{
    public interface IQualityDeteriateStratergy
    {
        string QualityControl(string name, int sellIn, int quality);     
    }
}
