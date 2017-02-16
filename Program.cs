using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // throw new DivideByZeroException();
                // Level1.Throw();
                // Level1.ThrowAnother();
                Level1.ThrowLevel2();
            }
            catch (Exception ex)
            {
                ExceptionWriter.ToConsole(ex);
            }
        }
    }
}
