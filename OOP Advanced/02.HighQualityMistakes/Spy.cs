using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string AnalyzeAcessModifiers(string className)
    {
        var result = new StringBuilder();

        var type = Type.GetType(className);

        CheckFieldsAccessModifiers(type, result);

        CheckGettersAccessModifiers(type, result);

        CheckSetersAccessModifiers(type, result);

        return result.ToString().TrimEnd();
    }

    private void CheckSetersAccessModifiers(Type type, StringBuilder result)
    {
        var allProperties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static);

        var nonPrivateSetters = allProperties.Where(p => p.SetMethod != null && p.SetMethod.IsPublic).ToList();

        nonPrivateSetters.ForEach(p => result.AppendLine($"{p.SetMethod.Name} have to be private!"));
    }

    private void CheckGettersAccessModifiers(Type type, StringBuilder result)
    {
        var allProperties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static);

        var notPublicGeters = allProperties.Where(p => p.GetMethod.IsPrivate).ToList();

        notPublicGeters.ForEach(g => result.AppendLine($"{g.GetMethod.Name} have to be public!"));

    }

    private void CheckFieldsAccessModifiers(Type type, StringBuilder result)
    {
        var publicFields = type.GetFields(BindingFlags.Public | BindingFlags.Static |
            BindingFlags.Instance).ToList();

        publicFields.ForEach(f => result.AppendLine($"{f.Name} must be private!"));
    }
}
