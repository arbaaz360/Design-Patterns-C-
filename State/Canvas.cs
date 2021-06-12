namespace State
{

    public class Canvas
    {
        public ITool selectedTool { get; set; }
        public void SelectTool(ITool tool)
        {
            selectedTool = tool;
        }
        public void MouseDown()
        {
            selectedTool.MouseDown();
        }

        public void MouseUp()
        {
            selectedTool.MouseUp();
        }

    }
}
