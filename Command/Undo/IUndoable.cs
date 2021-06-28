using System;
using System.Text;

namespace Command.Undo
{
    public interface IUndoable:ICommand
    {
        public void UnExecute();
    }
}
