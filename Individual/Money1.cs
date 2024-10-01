namespace Individual
{
    public class Money1 : Pair
    {
        public int GRN { get; set; }       
        public int Cop { get; set; }

        public Money1(int grn, int cop)
        {
            GRN = grn;
            Cop = cop;
        }

        public Money1(int grn) : this(grn, 0)
        {
            
        }

        public Money1() : this(0)
        {
            
        }

        public override double Add(double number)
        {
            double inCops = ToNumber();
            double result = inCops + number;
            return result;
        }

        public override double Divide(double number)
        {
            if(number == 0) throw new DivideByZeroException("Can not divide by zero.");
            double inCops = ToNumber();
            double result = inCops / number;
            return result;
        }

        public override double Multiply(double number)
        {
            double inCops = ToNumber();
            double result = inCops * number;
            return result;
        }

        public override double Subtract(double number)
        {
            double inCops = ToNumber();  
            double result = inCops - number;
            return result;
        }

        private double ToNumber()
        {
            return GRN + (0.100 * Cop);
        }

        public override string ToString()
        {
            return $"{GRN}uah {Cop}cop";
        } 
    }
}