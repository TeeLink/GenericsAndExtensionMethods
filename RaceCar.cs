using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    public class RaceCar : Vehicle
    {
        public RaceCar()
        {
            this.GasType = GasType.HighPerformance;
        }

        public override string ToString()
        {
            return "Race car";
        }
    }
}
