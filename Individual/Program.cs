//Variant 11;

namespace Individual;
public static class Program
{
    public static void Main()
    {
        Money1 money1 = new(259, 25);
        Money2 money2 = new();
        money2.ShowNominals(money1);
    }
}