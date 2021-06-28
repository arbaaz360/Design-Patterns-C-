using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Undo
{

    public class UndoCommand:ICommand
    {
        private History history { get; set; }

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if(history.Size() > 0)
            history.Pop().UnExecute();
        }
    }
}
