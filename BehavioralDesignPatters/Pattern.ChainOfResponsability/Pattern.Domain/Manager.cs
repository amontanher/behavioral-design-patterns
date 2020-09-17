using System;

namespace Pattern.ChainOfResponsability.Pattern.Domain
{
    public class Manager : HiringProcess
    {
        public override void HandleProcess(ProcessStep step)
        {
            if (ProcessStep.INTERVIEW.Equals(step))
                Console.WriteLine("--> Manager interviewd candidate.");
            else
                _sucessor.HandleProcess(step);
        }
    }
}
