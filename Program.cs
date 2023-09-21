namespace FactoryAppV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarFactory BMWFactory = new BMWFactory();
        }
    }
}