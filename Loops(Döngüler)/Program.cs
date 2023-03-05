using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Döngüler_
{
    class Program
    {
        static void Main(string[] args)
        {
            //// ForEachLoop();

            //if (AsalSayi(5))
            //{
            //    Console.WriteLine("asaldır");
            //}
            //else
            //{
            //    Console.WriteLine("Değildir");
            //}

            //string city = "Ankara";
            // Console.WriteLine(city);
            // string city2 = "İzmir";
            // string result = city + " " + city2;
            // Console.WriteLine(string.Format("{0}{1}",city,city2));
            string cumle = "My Name is mustafa";
            var result = cumle.Clone();
           bool sonuc= cumle.EndsWith("a");
            var sonuc2 = cumle.IndexOf(" ");
            var sonuc3 = cumle.LastIndexOf("a");
            var sonuc4 = cumle.Substring(3);
            var sonuc5 = cumle.ToLower();
            var sonuc6 = cumle.Replace(" ","-");
            Console.WriteLine(result);
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            Console.WriteLine(sonuc4);
            Console.WriteLine(sonuc5);
            Console.WriteLine(sonuc6);
            Console.ReadLine();

        }
        //private static bool AsalSayi(int number)
        //{
        //    bool result = true;
        //    for (int i = 2; i < number - 1; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            result = false;
        //            i = number;
        //        }

        //    }
        //    return result;

        //}


        private static void ForEachLoop()
        {
            int number = 100;
            int[] Yaslar = new int[4] { 1, 5, 9, 6 };


            //ForLoop();

            foreach (var yas in Yaslar)
            {
                Console.WriteLine(yas);
            }
        }

        private static void ForLoop()
        {
            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Bitiş");
        }
    }
}
