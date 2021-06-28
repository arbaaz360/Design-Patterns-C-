using System;
using System.Collections.Generic;

namespace Visitor
{
    public interface IOperation
    {
        void apply(HeadingNode heading);
        void apply(AnchorNode anchor);
    }

    public class HighlighOperation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("Highlighting Heading Node.");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlighting Anchor Node.");
        }
    }
    public interface HtmlNode
    {
        void Execute(IOperation operation);
    }
    public class AnchorNode : HtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
    public class HeadingNode : HtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.apply(this);
        }
    }

    public class HtmlDocument
    {
        private List<HtmlNode> nodes = new List<HtmlNode>();
        public void Add(HtmlNode node)
        {
            nodes.Add(node);
        }
        public void Execute(IOperation operation)
        {
            foreach(var node in nodes)
            {
                node.Execute(operation);
            }
        }
    }
   

}
