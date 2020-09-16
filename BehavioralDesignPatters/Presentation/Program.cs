using Pattern.ChainOfResponsability;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var chain = new ChainDemo();
            chain.Run();
        }
    }
}
