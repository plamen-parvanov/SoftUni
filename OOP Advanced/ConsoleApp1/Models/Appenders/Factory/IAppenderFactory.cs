namespace ConsoleApp1.Models.Appenders.Factory
{
    using Contracts;
    using Layouts.Contracts;

    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
