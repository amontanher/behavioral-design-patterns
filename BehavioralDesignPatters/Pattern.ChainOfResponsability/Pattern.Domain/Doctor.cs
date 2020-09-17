using System;
using System.Threading;

namespace Pattern.ChainOfResponsability.Pattern.Domain
{
    public class Doctor : HiringProcess
    {
        public override void HandleProcess(ProcessStep step)
        {
            if (ProcessStep.EXAMS.Equals(step))
            {
                Console.WriteLine("---> Doctor finished exams.");
                Thread.Sleep(1000);
            }
            else
                _sucessor.HandleProcess(step);
        }
    }
}
