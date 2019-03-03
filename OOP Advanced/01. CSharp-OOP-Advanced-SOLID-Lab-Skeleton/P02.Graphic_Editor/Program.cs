namespace P02.Graphic_Editor
{
    using Models.Shapes;
    using System;

    public class Program
    {
        public static void Main()
        {
            var graphicEditor = new GraphicEditor();

            Console.WriteLine(graphicEditor.DrawShape(new Rectangle()));
            Console.WriteLine(graphicEditor.DrawShape(new Circle()));
            Console.WriteLine(graphicEditor.DrawShape(new Square()));


        }
    }
}
