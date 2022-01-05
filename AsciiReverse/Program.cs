namespace AsciiReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var printArray = new PrintAsciiInReverse(new StringReverseFunctions());
            printArray.PrintAsciiToReverse();
        }
    }
}
