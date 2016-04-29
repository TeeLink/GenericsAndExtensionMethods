using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    public class Shop<T> where T : Vehicle
    {
        public void FillUp(T vehicle)
        {
                Console.WriteLine($"Fuel tank on {vehicle.ToString()} has been filled with {vehicle.GasType} gas.");

        }

        public void ChangeOil(T vehicle)
        {
            vehicle.IsOilChanged = true;
                Console.WriteLine($"{vehicle.ToString()}'s oilhas been changed.");
        }
    }

    
}
