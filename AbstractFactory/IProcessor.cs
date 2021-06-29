namespace AbstractFactory
{
    public interface IProcessor
    {
        string GetProcessor();
    }
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.I7.ToString();
        }
    }
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumerations.Processors.I5.ToString();
        }
    }


}
