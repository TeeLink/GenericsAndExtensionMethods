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
            vehicle.IsTankFilled = true;

            if (vehicle is Sedan)
            {
                Console.WriteLine("Fuel tank on sedan has been filled with regular gas.");
            }
            else if (vehicle is Truck)
            {
                Console.WriteLine("Fuel tank on truck has been filled with diesel.");
            }
            else 
            {
                Console.WriteLine("Fuel tank on race car has been filled with high performance fuel.");
            }

        }

        public void ChangeOil(T vehicle)
        {
            vehicle.IsOilChanged = true;

            if (vehicle is Sedan)
            {
                Console.WriteLine("Sedan's oil has been changed.");
            }
            else if (vehicle is Truck)
            {
                Console.WriteLine("Truck's oil has been changed.");
            }
            else
            {
                Console.WriteLine("Race car's oil has been changed.");
            }
        }
    }

    
}
