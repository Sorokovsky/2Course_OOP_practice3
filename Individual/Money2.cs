namespace Individual
{
    public class Money2
    {
        private readonly LinkedList<int> GRN_NOMINALS = new();

        public Money2()
        {
            GRN_NOMINALS.AddLast(1000);
            GRN_NOMINALS.AddLast(500);
            GRN_NOMINALS.AddLast(200);
            GRN_NOMINALS.AddLast(100);
            GRN_NOMINALS.AddLast(50);
            GRN_NOMINALS.AddLast(20);
            GRN_NOMINALS.AddLast(10);
            GRN_NOMINALS.AddLast(5);
            GRN_NOMINALS.AddLast(2);
            GRN_NOMINALS.AddLast(1);
        }

        public void ShowNominals(Money1 money)
        {
            int grn = money.GRN;
            int cop = money.Cop;
            while(grn > 0)
            {
                for(int i = 0; i < GRN_NOMINALS.Count; i++)
                {
                    int nominal = GRN_NOMINALS.ElementAt(i);           
                    if(grn % nominal >= 1)
                    {
                        grn -= nominal;
                        Console.WriteLine($"{nominal}uah.");
                        break;
                    }
                }
            }
        }        
    }
}