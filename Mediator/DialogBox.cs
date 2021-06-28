using System;

namespace Mediator
{

    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }

    public class UIControl
    {
        protected DialogBox owner;
        public UIControl(DialogBox owner)
        {
            this.owner = owner;
        }
    }

    public class ListBox : UIControl
    {
        private string selection;
        public ListBox(DialogBox owner): base(owner)
        {
            
        }
        public string GetSeclection()
        {
            return selection;
        }
        public void SetSelection(string selection)
        {
            this.selection = selection;
            owner.Changed(this);
        }
    }

    public class TextBox : UIControl
    {
        private string content;
        public TextBox(DialogBox owner) : base(owner)
        {
        }
        public void setContent(string content)
        {
            this.content = content;
        }
        public string getContent()
        {
            return this.content;
        }
    }
    public class Button : UIControl
    {
        private bool isEnabled;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool IsEnabled()
        {
            return this.isEnabled;
        }
        public void SetEnabled(bool enabled)
        {
            this.isEnabled = enabled;
        }
    }
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox articlesListBox { get; set; }
        private TextBox titleTextBox   { get; set; }
        private Button button{ get; set; }

        public void SimulateUsserInteraction()
        {
            articlesListBox.SetSelection("Article 1");
            Console.WriteLine("TextBox: "+ titleTextBox.getContent());
            Console.WriteLine("Button: "+ button.IsEnabled());
        }
        public ArticlesDialogBox()
        {
            this.articlesListBox = new ListBox(this);
            this.titleTextBox = new TextBox(this);
            this.button = new Button(this);
        }
        public override void Changed(UIControl control)
        {
            if (control == articlesListBox)
            {
                ArticleSelected();
            }
            else if (control == titleTextBox)
                TitleChanged();
        }

        private void TitleChanged()
        {
            var content = titleTextBox.getContent();
            var isEmpty = string.IsNullOrWhiteSpace(content);
            button.SetEnabled(!isEmpty);
        }

        private void ArticleSelected()
        {
            titleTextBox.setContent(articlesListBox.GetSeclection());
            button.SetEnabled(true);
        }
    }

}
