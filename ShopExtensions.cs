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
            vehicle.ChangeTires = true;

            if (vehicle is Sedan)
            {
                Console.WriteLine("Tires on sedan has been filled with regular gas.");
            }
            else if (vehicle is Truck)
            {
                Console.WriteLine("Tires on truck has been filled with diesel.");
            }
            else
            {
                Console.WriteLine("Tires on race car has been filled with high performance fuel.");
            }
        }
    }
}
