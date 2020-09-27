using System;

namespace Copy_Constructors
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;
        private int _result;

        public int Numerator
        {
            get
            {
                return _numerator; // sau get => _numerator
            }
            set
            {
                _numerator = value;
            }
        }

        public int Denominator
        {
            get => _denominator;
            set
            {
                if (value > 0)
                    _denominator = value;
                else
                    throw new ArgumentNullException();
            }
        }

        public Fraction()
        {
            _numerator = 0;
            _denominator = 1;
        }

        public Fraction(Fraction copyFraction)
        {
            _numerator = copyFraction._numerator;
            _denominator = copyFraction._denominator;
        }
    }
}
