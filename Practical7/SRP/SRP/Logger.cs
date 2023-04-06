using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SRP
{
    internal class Logger
    {
        public static void LogError(string error)
        {
            Console.Error.WriteLine($"Log-Error message: {error}");
        }

        public static void LogSuccess(string message)
        {
            Console.WriteLine($"Log-Success message: {message}");
        }
    }
}
