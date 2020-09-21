namespace Lab.Pattern.Command.Pattern.Domain
{
    public abstract class Command
    {
        protected SimpleCalculator _receiver;

        public Command(SimpleCalculator receiver)
        {
            _receiver = receiver;
        }

        public abstract int Execute();
    }
}
