using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem daxil edin");
            Action<string> action = IsDigit;
            action = IsEvenorOdd;
            action = DigitCount;
            //action = delegate (string value)
            //  {
            //      Console.WriteLine("sdjdj");
            //  };
           //ve ya
            ////action = n => Console.WriteLine("n");
            action.Invoke(Console.ReadLine());
        }


        public static void IsDigit(string value)
        {
            foreach (var item in value)
            {
                if (!char.IsDigit(item))
                {
                    Console.WriteLine("Reqem deyil");
                    break;
                }
            }
            Console.WriteLine("Reqemdir");
        }


        public static void IsEvenorOdd(string value)
        {
            int a = int.Parse(value);
            if (a % 2 == 0)
            {
                Console.WriteLine("Cutdur");
            }
            else
            {
                Console.WriteLine("Tekdir");
            }
        }


        public static void DigitCount(string value)
        {
            int a = int.Parse(value);
            int sum = 0;
            while (a > 0)
            {
                int qaliq = a % 10;
                sum += qaliq;
                a /= 10;
            }
        }
    }
}


