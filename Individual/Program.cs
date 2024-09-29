//Variant 11;

namespace Individual;
public static class Program
{
    private static Money1 _money1 = new();
    private static Money2 _money2 = new();

    public static void Main()
    {
        
        while(true)
        {
            int operation = ChooseOperation();
            switch(operation)
            {
                case 0:
                    {
                        return;
                    }
                case 1:
                    {
                        int grn, cop;
                        Console.Write("Enter a grn: "); grn = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter a cops: "); cop = Convert.ToInt32(Console.ReadLine());
                        _money1 = new(grn, cop);
                        break;
                    }
                case 2:
                    {
                        Calculate('+');
                        break;
                    }
                case 3:
                    {
                        Calculate('-');
                        break;
                    }
                case 4:
                    {
                        Calculate('*');
                        break;
                    }
                case 5:
                    {
                        Calculate('/');
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Unknown operation. Try again.");
                        break;
                    }
            }

        }
    }

    public static int ChooseOperation()
    {
        int operation;
        Console.WriteLine("Choose operation");
        Console.WriteLine("0-Exit.");
        Console.WriteLine("1-Enter money 1.");
        Console.WriteLine("2-Add.");
        Console.WriteLine("3-Subtract.");
        Console.WriteLine("4-Multiply.");
        Console.WriteLine("5-Divide.");
        Console.Write(">> "); operation = Convert.ToInt32(Console.ReadLine());
        return operation;
    }

    public static void Calculate(char operation)
    {
        int grn, cop;
        double money;
        double result = 0;
        Console.Write("Enter a grn: "); grn = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a cops: "); cop = Convert.ToInt32(Console.ReadLine());
        money = grn + (0.100 * cop);
        Money1 second = new(grn, cop);
        if (operation == '+')
        {
            result = _money1.Add(money);
        }
        if(operation == '-')
        {
            result = _money1.Subtract(money);
        }
        if (operation == '*')
        {
            result = _money1.Multiply(money);
        }
        if (operation == '/')
        {
            try
            {
                result = _money1.Divide(money);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        int resGrn = (int)result;
        int resCop = (int)(result - resGrn);
        Money1 res = new(resGrn, resCop);
        Console.WriteLine($"{_money1} {operation} {second} = {res}");
        _money2.ShowNominals(res);
    }
}