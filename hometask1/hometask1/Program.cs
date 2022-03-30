using hometask1.MODELS;
using System;

namespace hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(2);
            square.CalcArea();
            Rectangular rectangular = new Rectangular(3, 4);
            rectangular.CalcArea();
            Console.WriteLine("Enter some number");
            int a = Convert.ToInt32(Console.ReadLine());


            if (a == 1)
            {
                Console.WriteLine(square.CalcArea());

            }
            else if (a == 2)
            {
                Console.WriteLine(rectangular.CalcArea());

            }
            else if (a == 0)
            {
                Console.WriteLine(" Operation has ended ");
            }
            else
            {
                Console.WriteLine(" invalid number");
            }

        }
    }
}
