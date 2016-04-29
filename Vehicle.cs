using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    public enum GasType
    {
        Regular,
        Diesel,
        HighPerformance
    }
    public class Vehicle
    {
        public bool IsOilChanged { get; set; }
        public bool AreTiresChanged { get; set; }
        public bool IsTankFilled { get; set; }
        public GasType GasType { get; set; }
    }


}
