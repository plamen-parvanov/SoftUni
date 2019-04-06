public class StartUp
{
    public static void Main()
    {
        var spy = new Spy();
        var result = spy.CollectGettersAndSetters("System.Text.StringBuilder");
        System.Console.WriteLine(result);
    }
}
