using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fieldsName)
    {
        var type = Type.GetType(className);

        var allFields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static);

        var instance = Activator.CreateInstance(type, new object[] { });

        var wntedFields = allFields.Where(f => fieldsName.Any(n => n == f.Name)).ToList();

        var result = new StringBuilder();

        result.AppendLine($"Class under investigation: {className}");

        wntedFields.ForEach(f => result.AppendLine($"{f.Name} = {f.GetValue(instance)}"));

        return result.ToString().TrimEnd();
    }

    public string RevealPrivateMethods(string className)
    {
        var result = new StringBuilder();

        var type = Type.GetType(className);

        result.AppendLine($"All Private Methods of Class: {className}");
        result.AppendLine($"Base Class: {type.BaseType.Name}");

        AddAllPrivateMethods(type, result);

        return result.ToString().TrimEnd();
    }

    public string CollectGettersAndSetters(string className)
    {
        var result = new StringBuilder();

        var type = Type.GetType(className);

        var allproperties = type.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic |
            BindingFlags.Public);

        AddGetterMethodsInResult(allproperties, result);

        AddSetterMethodsInResult(allproperties, result);

        return result.ToString().TrimEnd();
    }

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

        var nonPrivateSetters = allProperties.Where(p => p.SetMethod?.IsPublic == true).ToList();

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

    private void AddSetterMethodsInResult(PropertyInfo[] allProperties, StringBuilder result)
    {
        var setters = allProperties.Where(m => m.SetMethod != null).ToList();

        setters.ForEach(s => result.AppendLine(string.Format("{0} will set field of {1}",
            s.SetMethod.Name, s.SetMethod.GetParameters().First().ParameterType)));
    }

    private void AddGetterMethodsInResult(PropertyInfo[] allProperties, StringBuilder result)
    {
        var getters = allProperties.Where(m => m.GetMethod != null).ToList();

        getters.ForEach(g => result.AppendLine($"{g.GetMethod.Name} will return {g.PropertyType}"));
    }

    private void AddAllPrivateMethods(Type type, StringBuilder result)
    {
        var allPrivateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).ToList();

        allPrivateMethods.ForEach(m => result.AppendLine(m.Name));
    }
}
