using System;
using System.Threading;

namespace Pattern.ChainOfResponsability.Pattern.Domain
{
    public class HRAnalyst : HiringProcess
    {
        public override void HandleProcess(ProcessStep step)
        {
            switch (step)
            {
                case ProcessStep.SELECTION:
                    Console.WriteLine("-> HR selected candidate.");
                    Thread.Sleep(1000);
                    break;

                case ProcessStep.FINISHED:
                    Console.WriteLine("----> HR finished hiring process.");
                    Thread.Sleep(1000);
                    break;

                default:
                    _sucessor.HandleProcess(step);
                    break;
            }
        }
    }
}
