using System;

namespace homework008
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int step = 7;
            for (firstNumber=5; firstNumber < 100; firstNumber += step)
                //for так как легче задать условие для последовательности цифр.
            {
                Console.WriteLine(firstNumber);
            }
        }
        }       
    }