using System;

namespace AsciiReverse
{
    class PrintAsciiInReverse
    {
        private readonly IStringReverse _stringReverse;

        public PrintAsciiInReverse(IStringReverse stringReverse)
        {
            _stringReverse = stringReverse;
        }

        public void PrintAsciiToReverse()
        {
            _stringReverse.StringToReverseAscii();
        }
    }
}
