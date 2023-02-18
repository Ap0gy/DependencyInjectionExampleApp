namespace DependencyInjectionExample.Logic
{
    public class BetterExampleLogic : IExampleLogic
    {
        public int Value1 { get; private set; }

        public int Value2 { get; private set; }

        public BetterExampleLogic()
        {
            Value1 = 25;
            Value2 = 50;
        }
    }
}
