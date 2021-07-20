using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AtvMetAbstratos.Entities
{
    class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int numberEmployees)
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
           if (NumberEmployees < 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }

        public override string TaxPride()
        {
            return Name
                + ": $ "
                + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
