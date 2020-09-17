namespace Pattern.ChainOfResponsability.Pattern.Domain
{
    public abstract class HiringProcess
    {
        protected HiringProcess _sucessor;

        public void SetSucessor(HiringProcess sucessor)
        {
            _sucessor = sucessor;
        }

        public abstract void HandleProcess(ProcessStep step);
    }
}