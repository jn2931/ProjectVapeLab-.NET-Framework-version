using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVapeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Project Vape Lab, created by Jakub Nowicki!");
            Console.WriteLine("Please enter the number of aromas you are going to use, and press 'enter'");
            int aromaNumber = Convert.ToInt32(Console.ReadLine());
            Aroma[] aromas = new Aroma[aromaNumber];
            for (int i = 0; i < aromas.Length; i++)
            {
                aromas[i] = new Aroma();                        // creating needed aroma objects
            }

            for (int i = 0; i < aromas.Length; i++)
            {                                                  // collecting aroma's names and percentages from user
                Console.WriteLine("Please enter the name of aroma nr." + (i + 1));
                aromas[i].name = Console.ReadLine();
                Console.WriteLine("Please enter the sugested percentage of aroma nr." + (i + 1));
                aromas[i].percentage = Convert.ToInt32(Console.ReadLine());
            }
            Eliquid finalProduct = new Eliquid();
            Console.WriteLine("Please enter the volume of final product you want to obtain (ml).");
            finalProduct.volume = Convert.ToInt32(Console.ReadLine());
            NeutralBase nbase = new NeutralBase();
            float aromaSumPercentage = 0;
            for (int i = 0; i < aromas.Length; i++)
            {
                aromaSumPercentage = aromaSumPercentage + aromas[i].percentage;
            }
            nbase.percentage = 100 - aromaSumPercentage;
            nbase.volume = (nbase.percentage / 100) * finalProduct.volume;

            for (int i = 0; i < aromas.Length; i++)
            {
                aromas[i].volume = (aromas[i].percentage / 100) * finalProduct.volume;
                Console.WriteLine(aromas[i].name + ": " + Math.Round(aromas[i].volume, 1) + "ml.");
            }
            Console.WriteLine("Neutral base/nicotine base: " + Math.Round(nbase.volume, 1) + "ml.");
            Console.ReadKey();
        }
    }
}
