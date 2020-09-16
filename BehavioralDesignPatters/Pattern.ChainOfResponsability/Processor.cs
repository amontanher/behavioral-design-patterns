using System;

namespace Pattern.ChainOfResponsability
{
    public class Processor
    {
        private static int NextID = 1;
        private readonly int Id = NextID++;
        private static readonly Random Random = new Random();

        public bool Execute(IProcess process)
        {
            if (Random.Next(2) != 0)
            {
                Console.WriteLine("   Processor " + Id + " is busy");
                return false;
            }

            Console.WriteLine("Processor " + Id + " - " + process.Process());
            return true;
        }
    }
}
