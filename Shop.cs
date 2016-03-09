using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    class Shop<T> where T : Vehicle
    {
        public void FillUp(T vehicle)
        {
            vehicle.TankFilled = true;

            if (vehicle is Sedan)
            {
                Console.WriteLine("Tank have been filled with regular gas.");
            }
            else if (vehicle is Truck)
            {
                Console.WriteLine("Tank have been filled with diesel.");
            }
            else 
            {
                Console.WriteLine("Tank have been filled with high performance fuel.");
            }

        }

        public void ChangeOil(T vehicle)
        {
            vehicle.OilChanged = true;
            Console.WriteLine("Oil has been changed.");
        }
    }

    
}
