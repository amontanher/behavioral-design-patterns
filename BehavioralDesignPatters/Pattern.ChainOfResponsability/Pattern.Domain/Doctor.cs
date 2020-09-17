using System;

namespace Pattern.ChainOfResponsability.Pattern.Domain
{
    public class Doctor : HiringProcess
    {
        public override void HandleProcess(ProcessStep step)
        {
            if (ProcessStep.EXAMS.Equals(step))
                Console.WriteLine("---> Doctor finished exams.");
            else
                _sucessor.HandleProcess(step);
        }
    }
}
