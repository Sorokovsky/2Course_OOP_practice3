namespace Individual
{
    public class Money2
    {
        private readonly LinkedList<int> GRN_NOMINALS = new();
        private readonly LinkedList<int> COP_NOMINALS = new();

        public Money2()
        {
            SetupGRNNominals();
            SetupCopNominals();
        }

        public void ShowNominals(Money1 money)
        {
            Console.WriteLine($"{money.GRN}uah {money.Cop}cop.");
            int grn = money.GRN;
            int cop = money.Cop;
            Console.WriteLine("Nominals");
            while (grn > 0)
            {
                for(int i = 0; i < GRN_NOMINALS.Count; i++)
                {
                    int nominal = GRN_NOMINALS.ElementAt(i);
                    int rest = grn / nominal;
                    if(rest >= 1)
                    {
                        grn -= nominal;
                        Console.WriteLine($"{nominal}uah.");
                        break;
                    }
                }
            }

            while(cop > 0)
            {
                for(int i = 0; i < COP_NOMINALS.Count;i++)
                {
                    int nominal = COP_NOMINALS.ElementAt(i);
                    int rest = cop / nominal;
                    if(rest >= 1)
                    {
                        cop -= nominal;
                        Console.WriteLine($"{nominal}cop");
                        break;
                    }
                }
            }
        }
        
        private void SetupGRNNominals()
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

        private void SetupCopNominals()
        {
            COP_NOMINALS.AddLast(10);
            COP_NOMINALS.AddLast(5);
            COP_NOMINALS.AddLast(2);
            COP_NOMINALS.AddLast(1);
        }
    }
}