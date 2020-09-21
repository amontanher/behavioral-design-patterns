namespace Lab.Pattern.Command.Pattern.Domain
{
    public class SubstractCommand : Command
    {
        private SimpleCalculator _calculator;

        public SubstractCommand(SimpleCalculator calculator) : base(calculator)
        {
            _calculator = calculator;
        }

        public override int Execute()
        {
            return _calculator.Subtract();
        }
    }
}
