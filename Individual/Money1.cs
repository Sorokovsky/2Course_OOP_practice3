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

        public override void Add(double number)
        {
            throw new NotImplementedException();
        }

        public override void Devide(double number)
        {
            throw new NotImplementedException();
        }

        public override void Multiply(double number)
        {
            throw new NotImplementedException();
        }

        public override void Subtract(double number)
        {
            throw new NotImplementedException();
        }
    }
}