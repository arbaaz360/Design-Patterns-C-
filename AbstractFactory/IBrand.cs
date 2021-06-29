using System;

namespace AbstractFactory
{

    public interface IBrand
    {
        string GetBrand();
    }
    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.DELL.ToString();
        }
    }
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.APPLE.ToString();
        }
    }

}
