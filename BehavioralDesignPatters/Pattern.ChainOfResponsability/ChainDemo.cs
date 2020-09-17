using Pattern.ChainOfResponsability.Pattern.Domain;
using System;

namespace Pattern.ChainOfResponsability
{
    public class ChainDemo
    {
        HiringProcess hr;
        HiringProcess doctor;
        HiringProcess manager;

        /// <summary>
        /// This demo is about a simple HR Process to hire an employee
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Starting ChainOfResponsability");

            SetupChainOfResponsabilities();
            SetupChainSucessors();

            ProcessStep[] hiringProcess = {
                ProcessStep.SELECTION,
                ProcessStep.INTERVIEW,
                ProcessStep.EXAMS,
                ProcessStep.FINISHED
            };

            foreach (var process in hiringProcess)
                hr.HandleProcess(process);

            Console.WriteLine("Finishing ChainOfResponsability");
        }

        private void SetupChainOfResponsabilities()
        {
            hr = new HRAnalyst();
            manager = new Manager();
            doctor = new Doctor();
        }

        private void SetupChainSucessors()
        {
            hr.SetSucessor(manager);
            manager.SetSucessor(doctor);
            doctor.SetSucessor(hr);
        }
    }
}
