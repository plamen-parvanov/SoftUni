namespace P01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                var commnad = Console.ReadLine();
                if (commnad == "HARVEST")
                {
                    break;
                }

                Execute(commnad);
            }
        }

        private static void Execute(string command)
        {
            var type = typeof(HarvestingFields);

            var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Static | BindingFlags.Instance);
      
            if(command != "all")
            {
                fields = fields.Where(f => f.Attributes.ToString().ToLower().Replace("family", "protected") == command)
                               .ToArray();
            }

            PrintFields(fields);
        }

        private static void PrintFields(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields)
            {
                var accessModifier = field.Attributes.ToString().ToLower();
                if (accessModifier == "family")
                {
                    accessModifier = "protected";
                }

                var fieldType = field.FieldType.Name;
                var fieldName = field.Name;

                 Console.WriteLine($"{accessModifier} {fieldType} {fieldName}");
            }
        }
    }
}
