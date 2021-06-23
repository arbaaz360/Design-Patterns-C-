namespace Template
{
    public class F16PreFlightCheckList : AbstractPreFlightCheckList
    {
        protected override void checkAirPressure()
        {
            System.Console.WriteLine("Checking air pressure in f16");
        }

        
        protected override bool hasDoor()
        {
            return false;
        }
    }


}
