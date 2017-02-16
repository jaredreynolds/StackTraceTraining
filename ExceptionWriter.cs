using System;
using System.Linq;

namespace ConsoleApplication
{
    public static class ExceptionWriter
    {
        public static void ToConsole(Exception ex)
        {
            while (ex != null)
            {
                System.Console.WriteLine($"{ex.GetType().FullName}: {ex.Message}");

                if (ex.StackTrace != null)
                {
                    System.Console.WriteLine(ex.StackTrace);
                }

                if (ex.InnerException == null)
                {
                    break;
                }

                ex = ex.InnerException;
            }
        }
    }
}
