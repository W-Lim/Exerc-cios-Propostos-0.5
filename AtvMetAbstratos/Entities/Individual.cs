using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AtvMetAbstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healExpenditures)
            : base (name, anualIncome)
        {
            HealExpenditures = healExpenditures;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealExpenditures * 0.50);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealExpenditures * 0.50);
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
