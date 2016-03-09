using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    public static class ShopExtensions
    {
        public static void ChangeTires<T> (this Shop<T> shop,  Vehicle vehicle) where T : Vehicle


        {
            vehicle.AreTiresChanged = true;

            if (vehicle is Sedan)
            {
                Console.WriteLine("Tires on sedan has been filled.");
            }
            else if (vehicle is Truck)
            {
                Console.WriteLine("Tires on truck has been filled.");
            }
            else
            {
                Console.WriteLine("Tires on race car has been filled.");
            }
        }
    }
}
