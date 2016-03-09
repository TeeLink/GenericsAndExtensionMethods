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
            Console.WriteLine("Tank have been filled.");
        }

        public void ChangeOil(T vehicle)
        {
            vehicle.OilChanged = true;
            Console.WriteLine("Oil has been changed.");
        }
    }

    
}
