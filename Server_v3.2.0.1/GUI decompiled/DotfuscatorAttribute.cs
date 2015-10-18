[AttributeUsage(1)]
public sealed class DotfuscatorAttribute : Attribute
{
    private string a;

    public DotfuscatorAttribute(string a)
    {
        base..ctor();
        this.a = a;
        return;
    }

    public string A
    {
        get
        {
            return this.a;
        }
    }
}
