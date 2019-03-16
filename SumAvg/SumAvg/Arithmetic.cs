 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAvg
{
    class Arithmetic
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int sum;
            int avg;
           

            Console.Write("Enter first integer :  ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer : ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third integer :  ");
            num3 = int.Parse(Console.ReadLine());

            sum = num1 + num2 + num3;
            avg = sum / 3;

            Console.WriteLine("The sum is " + sum);
            Console.WriteLine($"The average is {avg}");

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"The largest number is {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"The largest number is {num2}");
            }
            else
            {
                Console.WriteLine($"The largest number is {num3}");
            }

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"The smallest number is {num1}");
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine($"The smallest number is {num2}");
            }
            else
            {
                Console.WriteLine($"The smallest number is {num3}");
            }



            Console.ReadLine();


        }
    }
}
