namespace ConsoleApp1.Models.Layouts.Factory
{
    using System;

    using Contracts;
    using Layouts.Contracts;

    class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            ILayout layout;

            switch (type)
            {
                case "SimpleLayout":
                    layout = new SimpleLayout();
                    break;
                case "XmlLayout":
                    layout = new XmlLayout();
                    break;
                default:
                    throw new ArgumentException("Invalid Layout Type");
            }

            return layout;
        }
    }
}
