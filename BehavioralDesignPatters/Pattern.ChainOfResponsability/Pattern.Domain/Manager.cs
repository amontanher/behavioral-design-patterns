using System;
using System.Threading;

namespace Pattern.ChainOfResponsability.Pattern.Domain
{
    public class Manager : HiringProcess
    {
        public override void HandleProcess(ProcessStep step)
        {
            if (ProcessStep.INTERVIEW.Equals(step))
            {
                Console.WriteLine("--> Manager interviewd candidate.");
                Thread.Sleep(1000);
            }
            else
                _sucessor.HandleProcess(step);
        }
    }
}
