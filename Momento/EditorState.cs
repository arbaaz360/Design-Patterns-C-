using System;
using System.Collections.Generic;
using System.Text;

namespace Momento
{
    public class EditorState
    {
        private string content;
        public EditorState(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }

    }
}
