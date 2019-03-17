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

        var allMethods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance);

        AddGetterMethodsInResult(allMethods, result);

        AddSetterMethodsInResult(allMethods, result);

        return result.ToString().TrimEnd();
    }

    private void AddSetterMethodsInResult(MethodInfo[] allMethods, StringBuilder result)
    {
        var setters = allMethods.Where(m => m.Name.StartsWith("set")).ToList();

        setters.ForEach(s => result.AppendLine($"{s.Name} will set field of {s.GetParameters().First().ParameterType}"));
    }

    private void AddGetterMethodsInResult(MethodInfo[] allMethods, StringBuilder result)
    {
        var getters = allMethods.Where(m => m.Name.StartsWith("get")).ToList();

        getters.ForEach(g => result.AppendLine($"{g.Name} will return {g.ReturnType}"));
    }

    private void AddAllPrivateMethods(Type type, StringBuilder result)
    {
        var allPrivateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).ToList();

        allPrivateMethods.ForEach(m => result.AppendLine(m.Name));
    }
}
