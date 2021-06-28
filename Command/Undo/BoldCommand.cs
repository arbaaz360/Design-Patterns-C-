using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Undo
{
    public class BoldCommand : IUndoable
    {
        private string prevContent;
        private HtmlDocument document;
        private History history;

        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void Execute()
        {
            prevContent = document.GetContent();
            document.MakeBold();
            history.Push(this);
        }

        public void UnExecute()
        {
            document.SetContent(prevContent);
            // we will not pop history here. 
        }
    }
}
