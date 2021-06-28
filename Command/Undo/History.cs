using System.Collections.Generic;

namespace Command.Undo
{
    public class History
    {
        List<IUndoable> commands = new List<IUndoable>();

        public void Push(IUndoable command)
        {
            commands.Add(command);
        }
        public IUndoable Pop()
        {
            var last = commands[commands.Count - 1];
            commands.RemoveAt(0);
            return last;
        }

        public int Size()
        {
            return commands.Count;
        }
    }
}
