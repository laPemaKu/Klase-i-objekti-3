using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjekti3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1= new Stablo(true);
            Stablo stablo2 = new Stablo(false);
            Console.WriteLine("Stablo 1: " + stablo1.ToString());
            Console.WriteLine("Stablo 2: " + stablo2.ToString());
            Console.ReadKey();
            
        }
    }
    class Stablo
    {
        bool otpadajuListovi;
        string vrstaStabla;

        public override string ToString()
        {
            return "Stablo je " + this.vrstaStabla;
        }
        public Stablo()
        {

        }
        public Stablo(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
            if (otpadajuListovi == true)
            {
                this.vrstaStabla = "Bijelogorično";
            }
            else
            {
                this.vrstaStabla = "Crnogorično";
            }

        }
        public bool OtpadajuListovi { get=> otpadajuListovi; set=>otpadajuListovi=value;}
        public string VrstaStabla { get => vrstaStabla; set => vrstaStabla = value; }
    }
}
