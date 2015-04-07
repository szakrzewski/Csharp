using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProgram
{
    class Taxpayer
    {
        private int social;
        private double grossIncome;
        private double taxOwed;

        public Taxpayer(int social, double grossIncome)
        {
            this.social = social;
            this.grossIncome = grossIncome;

            
        }

        public int Social
        {
            get
            {
                return social;
            }

            set
            {
                social = value;
            }
        }

        public double GrossIncome
        {
            get 
            {
                return grossIncome;
            }

            set
            {
                grossIncome = value;
            }
        }

        public double TaxOwed
        {
            get
            {
                calculateTax();
                return taxOwed;
                
            }
        }

        private void calculateTax()
        {
            if (30000 > grossIncome)
            {
                taxOwed = grossIncome * .15;
                
            }

            else
            {
                taxOwed = grossIncome * .28;
               
            }
        }
    }
}
