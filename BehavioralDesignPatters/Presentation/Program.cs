using Pattern.ChainOfResponsability;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            InitMessage();

            Chain();
        }

        #region Console Props
        private static void InitMessage()
        {
            var message = "BEHAVIORAL DESIGN PATTERNS - GENERIC REPOSITORY";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        static void ConsoleColorMethod(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.NewLine + text + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region Invoke Patterns        

        private static void Chain()
        {
            ConsoleColorMethod("### [START] - CHAIN OF RESPONSABILITY ###");

            new ChainDemo().Run();

            ConsoleColorMethod("### [END] - CHAIN OF RESPONSABILITY ###");
        }

        #endregion
    }
}
