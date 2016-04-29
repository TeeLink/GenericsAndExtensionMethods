using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    public class Truck : Vehicle
    {
        public Truck()
        {
            this.GasType = GasType.Diesel;
        }

        public override string ToString()
        {
            return "Truck";
        }
    }
}
