using System;

namespace FactoryMethod
{
    public interface IEmployee
    {
        public int GetPay();
        public int GetBonus();
    }
    public class Employee
    {
        public int Bonus { get; set; }
        public int Pay { get; set; }
        public int MedicalAllwance { get; set; }
        public int HouseAllowance { get; set; }
        public int EmployeeTypeID { get; set; }
    }
    public class PermanentEmployee : IEmployee
    {
        public int GetBonus()
        {
            return 10;
        }

        public int GetPay()
        {
            return 20;
        }
        public int GetHouseAllowance() //extra
        {
            return 15;
        }
    }
    public class ContractEmployee : IEmployee
    {
        public int GetBonus()
        {
            return 3;
        }

        public int GetPay()
        {
            return 5;
        }
        public int GetMedicalAllowance()//extra
        {
            return 12;
        }
    }

    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;

        protected BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }

        public Employee ApplySalary()
        {
            IEmployee emp = this.Create();// ask concrete factory to build this object. Concrete factory will set only those properties that have relevance to Permanent/Contract Employee eg: HouseAllowance or Medical Allowance.
            _emp.Bonus = emp.GetBonus();//overwrite few properties  that are common. Ie. the properties that have relevance in both. GetPay() and GetBonus() are present in both. 
            _emp.Pay = emp.GetPay();
            return _emp;
        }
        protected abstract IEmployee Create();
    }

    public class PermanentEmployeeFactory:BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {

        }
        protected override IEmployee Create()
        {
            PermanentEmployee permanentEmp = new PermanentEmployee();
            _emp.HouseAllowance = permanentEmp.GetHouseAllowance();
            return permanentEmp;
        }
    }
}
