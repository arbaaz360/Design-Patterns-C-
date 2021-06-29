namespace AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeID == 1)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new MACLaptopFactory();
                }
                else
                {
                    returnValue = new MACDesktopFactory();
                }
            }
            else if (e.EmployeeTypeID == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                    returnValue = new DellDesktopFactory();
            }
            return returnValue;
        }
    }


}
