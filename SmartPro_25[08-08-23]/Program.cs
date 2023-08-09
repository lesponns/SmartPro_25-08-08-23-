using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_25_08_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, last = 0;
            double avarage;
            Console.Write("Limit: ");
            input = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= input; i++) 
            {
                last += i; //last = last + i;
            }
            avarage = (double)last / input;
            Console.WriteLine("1'den {0} sayısına kadar olan sayıların toplamı: {1}\nSayıların ortalaması: {2}",input,last,avarage);
            Console.ReadKey();
        }
    }
}
