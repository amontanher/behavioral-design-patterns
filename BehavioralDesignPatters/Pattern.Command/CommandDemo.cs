using Lab.Pattern.Command.Pattern.Domain;
using System;
using System.Threading;

namespace Pattern.Command
{
    public class CommandDemo
    {
        /// <summary>
        /// This demo is about a simple calculator operatores
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Initializing calculator...");
            SimpleCalculator calculator = new SimpleCalculator(15, 3);
            Thread.Sleep(500);

            Console.WriteLine("Adding commands...");
            var addCommand = new AddCommand(calculator);
            var substractCommand = new SubstractCommand(calculator);
            Thread.Sleep(500);

            Invoker invoker = new Invoker();

            invoker.SetCommand(addCommand);
            Console.WriteLine("[AddCommand] Result is {0}", invoker.Execute());
            invoker.SetCommand(substractCommand);
            Console.WriteLine("[SubstractCommand] Result is {0}", invoker.Execute());
        }
    }
}