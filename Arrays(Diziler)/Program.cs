using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Diziler_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string[] students = new string[3] { "Brinici", "İkinci", "üçüncü" };


            //    foreach (var item in students)
            //    {
            //        Console.WriteLine(item);
            //    }

            string[,] bolgeler = new string[4, 3]
            {
                                { "BirinBiri","Birinİkisi","BirinÜçü"},
                                { "ikininBiri","ikininİkisi","İkininÜçü"},

                                { "ÜçünBiri","Üçünİkisi","ÜçünÜçü"},

                                { "DördünBiri","Dördünİkisi","DördünÜçü"}

            };
            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i, j]);
                }
                Console.WriteLine("--------------------");
            }

            Console.ReadLine();

        }

    }
}
