namespace Individual
{
    public static class Money2
    {
        private static readonly int[] GRN_NOMINALS = [100, 500, 200, 100, 50, 20, 10, 5, 2, 1];


        public static void ShowNominals(Money1 money)
        {
            int grn = money.GRN;
            int cop = money.Cop;
            while(grn != 0)
            {
                for(int i = 0; i < GRN_NOMINALS.Length; i++)
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