using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleByThree());
        }
        static int DivisibleByThree()
        {
            int count = 0;
            for(int i = 1; i < 101; i++)
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
            while (isNumber) {
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
        }



    }
    }


}
       