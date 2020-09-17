using Pattern.ChainOfResponsability.Pattern.Domain;
using System.Threading;

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
            SetupChainOfResponsabilities();
            SetupChainSucessors();

            ProcessStep[] hiringProcess = {
                ProcessStep.SELECTION,
                ProcessStep.INTERVIEW,
                ProcessStep.EXAMS,
                ProcessStep.FINISHED
            };

            foreach (var process in hiringProcess)
            {
                hr.HandleProcess(process);
                Thread.Sleep(1000);
            }
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
