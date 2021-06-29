namespace AbstractFactory
{
    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }

    public class DellDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new DELL();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class DellLaptopFactory : DellDesktopFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }


    public class MACDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class MACLaptopFactory : MACDesktopFactory
    {

        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }


}
