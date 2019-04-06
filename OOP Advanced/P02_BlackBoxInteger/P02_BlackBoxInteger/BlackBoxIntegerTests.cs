namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;
    using System.Text;

    public class BlackBoxIntegerTests
    {
        private static StringBuilder outPutMessage;

        public static void Main()
        {
            outPutMessage = new StringBuilder();

            string commandLine;

            var bindingFlags = BindingFlags.NonPublic |
                BindingFlags.Static | BindingFlags.Instance;

            var type = typeof(BlackBoxInteger);

            var instance = Activator.CreateInstance(type, true);

            while ((commandLine = Console.ReadLine()) != "END")
            {
                Execute(commandLine, type, instance, bindingFlags);
            }

            PrintResult();
        }

        private static void PrintResult()
        {
            Console.WriteLine(outPutMessage.ToString().TrimEnd());
        }

        private static void Execute(string commandLine, Type type,
            object instance, BindingFlags bindingFlags)
        {
            var commandArr = commandLine.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

            var command = commandArr[0];
            var value = int.Parse(commandArr[1]);
   
            var method = type.GetMethod(command, bindingFlags);

            method.Invoke(instance, new object[] { value });

            var field = type.GetField("innerValue", bindingFlags);
            var result = field.GetValue(instance);

            outPutMessage.AppendLine(result.ToString());
        }


    }
}
