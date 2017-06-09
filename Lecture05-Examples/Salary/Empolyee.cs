using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Empolyee
    {
        private double basesalary;
        private double benefit;
        private double salary;

        public double BaseSalary
        {
            get { return basesalary; }
            set
            {
                if (value < 0)
                {
                    this.basesalary = 0;
                }
                else
                    this.basesalary = value;
            }
        }

        public double Benefit
        {
            get { return benefit; }
            set
            {
                if (value < 0)
                {
                    this.benefit = 0;
                }
                else
                    this.benefit = value;
            }
        }

        public double Salary
        {
            get { return BaseSalary + Benefit; }
        }
    }
}