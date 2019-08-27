using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            //RandomPick();
            maxNumber();



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
            var secretNumber = random.Next(1,10);
            

            Console.WriteLine($"secret number {secretNumber}");

            for (int i = 0; i < 4; i++)
            {
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

        static void maxNumber()
        {
            Console.WriteLine("please enter numbers separated by coma");
            var numbers = Console.ReadLine();
            int[] separatedNumbers = new int[numbers.Length/2 + 1];
            separatedNumbers[0] = numbers[0];
            Console.WriteLine(numbers[0]);
            int maxNumber = numbers[0];
            for (var i = 1; i < numbers.Length/2; i++)
            {
                separatedNumbers[i] = int.Parse(char.ToString(numbers[i + 1]));
                if (maxNumber < separatedNumbers[i])
                {
                    maxNumber = separatedNumbers[i];
                }



            }

            Console.WriteLine(maxNumber);
            
            
        }



    }
}



