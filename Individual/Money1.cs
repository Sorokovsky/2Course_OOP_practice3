namespace Individual
{
    public class Money1 : Pair
    {
        private int _grn;
        private int _cop;
        public int GRN 
        {
            get 
            {
                return _grn;
            }
            set
            {
                if(value < 0)
                {
                    _grn = 0;
                }
                else
                {
                    _grn = value;
                }
            }
        }       
        public int Cop
        {
            get
            {
                return _cop;
            }
            set
            {
                if(value < 0)
                {
                    _cop = 0;
                }
                else 
                {
                    _cop = value;
                }
            }
        }

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
            number *= 100;
            return inCops + number;
        }

        public override double Divide(double number)
        {
            if(number == 0) throw new DivideByZeroException("Can not divide by zero.");
            number *= 100;
            double inCops = ToNumber();
            return inCops / number;
        }

        public override double Multiply(double number)
        {
            number *= 100;
            double inCops = ToNumber();
            return inCops * number;
        }

        public override double Subtract(double number)
        {
            number *= 100;
            double inCops = ToNumber();  
            return inCops - number;
        }

        private double ToNumber()
        {
            return GRN * 100 + Cop;
        }
    }
}