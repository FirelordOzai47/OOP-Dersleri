using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler_Cont_metot_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Yaslar = new int[25];
            for (int i = 0; i <Yaslar.Length ; i++)
            {
                Yaslar[i] += i;
               
            }  
            Console.Read();
        }
    }
}
