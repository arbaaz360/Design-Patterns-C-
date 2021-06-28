using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class AddCustomerCommand : ICommand
    {
        public CustomerService service;
        public AddCustomerCommand(CustomerService service)
        {
            this.service = service;
        }
        public void Execute()
        {
            service.AddCustomer();
        }
    }
}
