using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DivisibleByThree());
            //EnterNumber();
            //Console.WriteLine("enter numbers");
            //int factorialNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(Factorial(factorialNumber));
            RandomPick();


        }
        static int DivisibleByThree()
        {
            int count = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            return count;

        }

        static void EnterNumber()
        {

            int number = 0;
            bool isNumber = true;
            while (isNumber)
            {
                Console.WriteLine("Enter numbers and then pas ok");
                var enteredNumber = Console.ReadLine();
                if (enteredNumber == "ok")
                {
                    isNumber = false;
                }
                else
                {
                    number += int.Parse(enteredNumber);
                }
            }
            Console.WriteLine(number);
        }

        static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }

        }

        static void RandomPick()
        {
            var random = new Random();
            var secretNumber = random.Next(1, 10);

            Console.WriteLine("guess number");
            Console.WriteLine($"secret number {0}", secretNumber);
            var pickedNumber = int.Parse(Console.ReadLine());
            if (pickedNumber == secretNumber)
            {
                Console.WriteLine("you won");
            }
            else
            {
                Console.WriteLine("you lose");
            }
        }



    }
}



