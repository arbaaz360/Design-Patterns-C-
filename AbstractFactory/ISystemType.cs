namespace AbstractFactory
{
    public interface ISystemType
    {
        string GetSystemType();
    }

    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerTypes.Laptop.ToString();
        }
    }
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerTypes.Desktop.ToString();
        }
    }
}
