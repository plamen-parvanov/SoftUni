namespace P02.Graphic_Editor.Models.Shapes
{
    using Contracts;

    public class GraphicEditor
    {
        public string DrawShape(IShape shape)
        {
            return shape.Draw();
        }
    }
}
