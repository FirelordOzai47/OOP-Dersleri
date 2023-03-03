using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add();
            //var result= Add2(10);
            // Console.WriteLine(result);

            //int number1 = 20;
            ////int number2 = 100;
            ////var result = Add3(out number1, number2);
            //Console.WriteLine(result);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2,4,5));
            Console.WriteLine(Add4(2,3,5,8));
            Console.ReadLine();



        }
        static void Add()
        {
            Console.WriteLine("Toplandı");

        }
        static int Add2(int number1, int number2 = 20)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number2 + number1;

        }
        static int Multiply (int number1,int number2)
        {
        return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
