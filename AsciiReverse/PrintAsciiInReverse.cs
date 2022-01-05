namespace AsciiReverse
{
    class PrintAsciiInReverse
    {
        /// <summary>
        /// Referencing Interfase IStringReverse
        /// </summary>
        private readonly IStringReverse _stringReverse;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="stringReverse">Reference Variable For IStringReverse</param>
        public PrintAsciiInReverse(IStringReverse stringReverse)
        {
            _stringReverse = stringReverse;
        }

        /// <summary>
        /// Print ASCII Value In Reverse Order If It Is Prime
        /// </summary>
        public void PrintAsciiToReverse()
        {
            // Calling Function StringToReverseAscii() 
            _stringReverse.StringToReverseAscii();
        }
    }
}
