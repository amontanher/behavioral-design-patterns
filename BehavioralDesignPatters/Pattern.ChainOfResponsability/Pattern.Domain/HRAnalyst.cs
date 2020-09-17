using System;

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
                    break;

                case ProcessStep.FINISHED:
                    Console.WriteLine("----> HR finished hiring process.");
                    break;

                default:
                    _sucessor.HandleProcess(step);
                    break;
            }
        }
    }
}
