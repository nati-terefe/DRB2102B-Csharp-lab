using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lap_assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int choice;
            String ans;
            Console.WriteLine("----------------welcome---------------------------\n");
            do
            {
                Console.WriteLine("Please enter first number:");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter second number:");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Choose you're operation:");
                Console.WriteLine("1.Addition:");
                Console.WriteLine("2.Substracion:");
                Console.WriteLine("3.Multiplication:");
                Console.WriteLine("4.Division:");
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("The result is :");
                    Console.WriteLine(num1 + num2);
                }
                if (choice == 2)
                {
                    Console.WriteLine("The result is :");
                    Console.WriteLine(num1 - num2);
                }
                if (choice == 3)
                {
                    Console.WriteLine("The result is :");
                    Console.WriteLine(num1 * num2);
                }
                if (choice == 4)
                {
                    Console.WriteLine("The result is :");
                    Console.WriteLine(num1 * num2);
                    Console.WriteLine("remainder:");
                    Console.WriteLine(num1 % num2);
                }
               if(choice<1 || choice>4)
             Console.WriteLine("Wrong input please try again!!");
                Console.WriteLine("If you want to continue type yes, to exit press any key");
           ans=Console.ReadLine();
            } while (ans=="yes" | ans=="y" || ans=="Yes" || ans=="Y");

        }
    }
}
