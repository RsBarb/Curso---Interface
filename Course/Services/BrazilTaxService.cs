using System;

namespace Course.Services
{
    class BrazilTaxService : ITaxService //realização de interface e nao herança.
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
