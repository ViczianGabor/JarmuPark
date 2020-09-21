using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class Auto
    {
        private string szin;
        private string tipus;
        private double uzemanyag;
        private double fogyaszt;
        private double km;
        private double megteheto;


        public double KM { get { return km; } }
        public double UZEMANYAG { get { return uzemanyag; } }
        public double MEGTEHETO { get { return megteheto; } }

        public Auto (string szin, string tipus, double fogyaszt)
        {
            this.szin = szin;
            this.tipus = tipus;
            this.fogyaszt = fogyaszt;
            this.km = 0;
            this.uzemanyag = 0;
        }

        public void tankol(double mennyit)
        {

            uzemanyag += mennyit;
            megtehetoo();

        }

        public void megy (double km)
        {
            this.km += km;
            uzemanyag -= (km*fogyaszt/100);
            megtehetoo();


        }

        public void allapot()
        {

            Console.WriteLine($"{ tipus} - { szin}");
            Console.WriteLine($"KM óra {km}");
            Console.WriteLine($"Üzemanyag: {uzemanyag} l");
            Console.WriteLine($"fogyasztás: {fogyaszt} l/100km");
            Console.WriteLine("Megtehető km: {0}",megteheto);

            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void megtehetoo() 
        {
            megteheto = uzemanyag / fogyaszt * 100;

        }

    }
}
