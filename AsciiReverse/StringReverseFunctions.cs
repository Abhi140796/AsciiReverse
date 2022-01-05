using System;

namespace AsciiReverse
{
    class StringReverseFunctions : IStringReverse
    {

        private string notAPrime = "Not a prime number";

        /// <summary>
        /// Check Weather The Given Number Is Prime Or Not
        /// </summary>
        /// <param name="wholeNumber">Whole Number</param>
        /// <returns>Bool Value True If It Is Prime And False If Not</returns>
        public bool IsPrimeNumber(int wholeNumber)
        {
            if (wholeNumber % 2 != 0 && wholeNumber % 3 != 0 && wholeNumber % 5 != 0)
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

                Console.WriteLine("{0}{1,18}",number,"|");
            }

            else
            {
                Console.WriteLine("{0}{1,2}",notAPrime,"|");
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

            Console.WriteLine("");
            Console.WriteLine("{0,-15}{1,-5}{2,-5}","Characters","|","Prime/Not Prime");
            for(int i = 0; i < 40; i++)
            {
                Console.Write("_");
            }

            Console.WriteLine();

            foreach (var element in wordArray)
            {
                Console.Write("{0,-10}{1,-5}{2,-5}", "|",element,"|");
                ReverseAcii((int)element);
            }

            for (int i = 0; i < 40; i++)
            {
                Console.Write("_");
            }
        }
    }
}
