using System;

namespace ConsoleApplication
{
    public static class Level2
    {
        public static void Throw()
        {
            throw new DivideByZeroException();
        }
    }
}