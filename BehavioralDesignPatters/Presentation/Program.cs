using Pattern.ChainOfResponsability;
using Pattern.Command;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            InitMessage();

            //Chain();

            Command();
        }

        #region Console Props
        private static void InitMessage()
        {
            var message = "BEHAVIORAL DESIGN PATTERNS - GENERIC REPOSITORY";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        static void ConsoleColorMethod(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Environment.NewLine + text + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region Invoke Patterns        

        private static void Chain()
        {
            ConsoleColorMethod("### [START] - CHAIN OF RESPONSABILITY ###", ConsoleColor.Green);

            new ChainDemo().Run();

            ConsoleColorMethod("### [END] - CHAIN OF RESPONSABILITY ###", ConsoleColor.Green);
        }

        private static void Command()
        {
            ConsoleColorMethod("### [START] - COMMAND ###", ConsoleColor.Blue);

            new CommandDemo().Run();

            ConsoleColorMethod("### [END] - COMMAND ###", ConsoleColor.Blue);
        }

        #endregion
    }
}
