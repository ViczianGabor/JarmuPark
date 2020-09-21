using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Auto Lada = new Auto("Piros","Lada 2112",11);
            Auto Trabant = new Auto("Zöld","Trabant 1.1",8);


            Lada.tankol(20);
            Trabant.tankol(20);


            Lada.allapot();
            Trabant.allapot();

            Console.WriteLine();

            Console.WriteLine("Mennyit menjen a Lada?");
            int ee = int.Parse(Console.ReadLine());
            Console.WriteLine("Mennyit menjen a Trabant?");
            int aa = int.Parse(Console.ReadLine());
            
            Lada.megy(ee);
            Trabant.megy(aa);



            Lada.allapot();
            Trabant.allapot();




            Console.ReadKey();
        }
    }
}
