using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    public class Sedan : Vehicle
    {
        public Sedan()
        {
            this.GasType = GasType.Regular;
        }

        public override string ToString()
        {
            return "Sedan";
        }
    }
}
