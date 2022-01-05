namespace AsciiReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayOutput();
        }

        static void DisplayOutput()
        {
            var printArray = new PrintAsciiInReverse(new StringReverseFunctions());
            printArray.PrintAsciiToReverse();
        }
    }
}
