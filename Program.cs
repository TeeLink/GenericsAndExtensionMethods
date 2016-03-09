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
        
        Console.WriteLine($"Sedan oil changed: {s.IsOilChanged}. Sedan tires filled: {s.AreTiresChanged}. Sedan fuel tank filled {s.IsTankFilled}.");
        Console.WriteLine($"Truck oil changed: {t.IsOilChanged}. Truck tires filled: {t.AreTiresChanged}. Truck fuel tank filled {t.IsTankFilled}.");
        Console.WriteLine($"Race car oil changed: {rc.IsOilChanged}. Race car tires filled: {rc.AreTiresChanged}. Race car fuel tank filled {rc.IsTankFilled}.");



        jetts.FillUp(s);
        jetts.ChangeOil(s);
        jetts.ChangeTires(s);

        shendos.FillUp(t);
        shendos.ChangeOil(t);
        shendos.ChangeTires(t);

        boogies.FillUp(rc);
        boogies.ChangeOil(rc);
        boogies.ChangeTires(rc);

        Console.WriteLine($"Sedan oil changed: {s.IsOilChanged}. Sedan tires filled: {s.AreTiresChanged}. Sedan fuel tank filled {s.IsTankFilled}.");
        Console.WriteLine($"Truck oil changed: {t.IsOilChanged}. Truck tires filled: {t.AreTiresChanged}. Truck fuel tank filled {t.IsTankFilled}.");
        Console.WriteLine($"Race car oil changed: {rc.IsOilChanged}. Race car tires filled: {rc.AreTiresChanged}. fuel Race car tank filled {rc.IsTankFilled}.");


        Console.ReadLine();

        }
    }
}
