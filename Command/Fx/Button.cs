using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Button
    {
        private string label;
        private ICommand command;
        public Button(ICommand command)
        {
            this.command = command;
        }
        public void click()
        {
            command.Execute();
        }
        public string getLabel()
        {
            return label;
        }
    }
}
