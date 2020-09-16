using System;

namespace Pattern.ChainOfResponsability
{
    public class ChainDemo
    {
        public void Run()
        {
            IProcess[] process = { new Select() };
            Processor[] processors = { new Processor() };

            for (int i = 0, j; i < process.Length; i++)
            {
                Console.WriteLine($"Operation #{i + 1}:");
                j = 0;
                while (!processors[j].Execute(process[i]))
                {
                    j = (j + 1) % processors.Length;
                }
                Console.WriteLine("Finishing processing...");
            }
        }
    }
}
