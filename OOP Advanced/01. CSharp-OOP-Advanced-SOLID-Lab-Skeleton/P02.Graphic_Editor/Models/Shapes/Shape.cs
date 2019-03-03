namespace P02.Graphic_Editor.Models.Shapes
{
    using Contracts;

    public abstract class Shape : IShape
    {
        public string Draw()
        {
            return $"I'm {this.GetType().Name}";
        }
    }
}
