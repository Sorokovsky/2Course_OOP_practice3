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

        public override double Add(double number)
        {
            throw new NotImplementedException();
        }

        public override double Devide(double number)
        {
            throw new NotImplementedException();
        }

        public override double Multiply(double number)
        {
            throw new NotImplementedException();
        }

        public override double Subtract(double number)
        {
            throw new NotImplementedException();
        }
    }
}