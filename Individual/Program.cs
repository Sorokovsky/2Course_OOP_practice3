//Variant 11;

namespace Individual;
public static class Program
{
    public static void Main()
    {
        Money1 money1 = new Money1();
        money1.GRN = 157;
        money1.Cop = 0;
        Money2.ShowNominals(money1);
    }
}