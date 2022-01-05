using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiReverse
{
    class StringReverseFunctions : IStringReverse
    {
        public bool IsPrimeNumber(int wholeNumber)
        {
            if(wholeNumber % 2 != 0 && wholeNumber % 3 != 0 && wholeNumber % 5 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Create reverse ASCII value 
        /// </summary>
        /// <param name="asciiNumber"> ASCII number</param>
        public void ReverseAcii(int asciiNumber)
        {
            int number = 0;
            bool isAsciiNumberIsPrime = IsPrimeNumber(asciiNumber);
            if(isAsciiNumberIsPrime)
            {
                while (asciiNumber != 0)
                {
                    number = number * 10;
                    number = number + asciiNumber % 10;
                    asciiNumber = asciiNumber / 10;
                }

                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
  
        }

        /// <summary>
        /// Convert Character to ASCII value 
        /// and print in reverse order.   
        /// </summary>
        public void StringToReverseAscii()
        {
            Console.WriteLine("Enter a String");
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            foreach (var element in wordArray)
            {
                Console.Write("{0,-10}: ",element);
                ReverseAcii((int)element);
            }
        }
    }
}
