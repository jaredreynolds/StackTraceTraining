using System;

namespace ConsoleApplication
{
    public static class Level1
    {
        public static void Throw()
        {
            throw new DivideByZeroException();
        }

        public static void ThrowAnother()
        {
            Throw();
        }

        public static void ThrowLevel2()
        {
            Level2.Throw();
        }
    }
}