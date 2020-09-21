namespace Lab.Pattern.Command.Pattern.Domain
{
    public class AddCommand : Command
    {
        private SimpleCalculator _calculator;

        public AddCommand(SimpleCalculator calculator) : base(calculator)
        {
            _calculator = calculator;
        }

        public override int Execute()
        {
            return _calculator.Add();
        }
    }
}
