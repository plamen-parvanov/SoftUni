public class Children
{
    public string childName;
    public string childBirthday;

    public Children(string childName, string childBirthday)
    {
        this.childName = childName;
        this.childBirthday = childBirthday;
    }

    public override string ToString()
    {
        return $"{this.childName} {this.childBirthday}";
    }
}