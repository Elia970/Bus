using cesaretti.elia._4j.OrariBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesaretti.elia._4j.OrariBus
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            Orario Partenza170 = new Orario(6, 21);
            Console.WriteLine("Orario partenza: " + Partenza170.Visualizza());
            Partenza170.minuti = Partenza170.minuti + 40;
            Console.WriteLine("Orario partenza: " + Partenza170.Visualizza());
            Console.ReadLine();
            f = Partenza170.GetMinuti();
            Console.WriteLine(f);
        }
    }
}