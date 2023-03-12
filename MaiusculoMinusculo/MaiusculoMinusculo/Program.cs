using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiusculoMinusculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> frutas = new List<string> ();

            frutas.Add("Maçã");
            frutas.Add("banaNa");
            frutas.Add("Uva");
            frutas.Add("MelAncia");
            frutas.Add("mangA");

            frutas = frutas.ConvertAll(low => low.ToLowerInvariant());


            foreach (string item in frutas)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
