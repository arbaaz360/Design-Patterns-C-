using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Undo
{
    public class HtmlDocument
    {
        private string content { get; set; }
        public string GetContent()
        {
            return content;
        }
        public void SetContent(string content)
        {
            this.content = content;
        }
        public void MakeBold()
        {
            this.content =  "<b>" + this.content + "</b>";
        }
    }
}
