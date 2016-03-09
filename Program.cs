using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Shop<Sedan> jetts = new Shop<Sedan>();
        Shop<Truck> shendos = new Shop<Truck>();
        Shop<RaceCar> boogies = new Shop<RaceCar>();

        Sedan s = new Sedan();
        Truck t = new Truck();
        RaceCar rc = new RaceCar();
        
        Console.WriteLine($"Sedan oil changed: {s.OilChanged}. Sedan tires filled: {s.TiresChanged}. Sedan tank filled {s.TankFilled}.");
        Console.WriteLine($"Truck oil changed: {t.OilChanged}. Truck tires filled: {t.TiresChanged}. Truck tank filled {t.TankFilled}.");
        Console.WriteLine($"Race car oil changed: {rc.OilChanged}. Race car tires filled: {rc.TiresChanged}. Race car tank filled {rc.TankFilled}.");



        jetts.FillUp(s);
        jetts.ChangeOil(s);
        jetts.ChangeTires(s);

        shendos.FillUp(t);
        shendos.ChangeOil(t);
        shendos.ChangeTires(t);

        boogies.FillUp(rc);
        boogies.ChangeOil(rc);
        boogies.ChangeTires(rc);

        Console.WriteLine($"Sedan oil changed: {s.OilChanged}. Sedan tires filled: {s.TiresChanged}. Sedan tank filled {s.TankFilled}.");
        Console.WriteLine($"Truck oil changed: {t.OilChanged}. Truck tires filled: {t.TiresChanged}. Truck tank filled {t.TankFilled}.");
        Console.WriteLine($"Race car oil changed: {rc.OilChanged}. Race car tires filled: {rc.TiresChanged}. Race car tank filled {rc.TankFilled}.");


        Console.ReadLine();

        }
    }
}
