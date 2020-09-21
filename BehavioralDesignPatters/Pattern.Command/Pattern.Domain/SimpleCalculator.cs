namespace Lab.Pattern.Command.Pattern.Domain
{
    public class SimpleCalculator
    {
        private readonly int _x;
        private readonly int _y;

        public SimpleCalculator(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int Add()
        {
            return _x + _y;
        }
        public int Subtract()
        {
            return _x - _y;
        }
    }
}
