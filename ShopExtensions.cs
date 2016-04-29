using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    public static class ShopExtensions
    {
        public static void ChangeTires<T>(this Shop<T> shop, Vehicle vehicle) where T : Vehicle


        {
            vehicle.AreTiresChanged = true;

           
                Console.WriteLine($"Tires on {vehicle.ToString()} has been filled.");
          
        }
    }
}
