using System;

namespace LitwareLib
{
    public class Employee
    {
        int EmpNo;
        string EmpName;
        protected double Salary;
        double HRA;
        double TA;
        double DA;
        protected double PF;
        protected double TDS;
        protected double NetSalary;
        double GrossSalary;

        public void setempno(int empno)
        {
            this.EmpNo = empno;
        }
        public void getEmpNo()
        {
            Console.WriteLine("Employee Number is: " + this.EmpNo);
        }

        public void setempname(string empname)
        {
            this.EmpName = empname;
        }
        public void getEmpName()
        {
            Console.WriteLine("Employee Name is: " + this.EmpName);
        }

        public void setEmpSalary(double Sal)
        {
            this.Salary = Sal;
        }
        public void getEmpSalary()
        {
            Console.WriteLine("Employee Salary is: " + this.Salary);
        }
        public void sethra()
        {
            double hra;
            switch (Salary)
            {
                case double n when n > 0 & n < 5000:
                    hra = (10 * Salary) / 100;
                    this.HRA = hra;
                    break;
                case double n when n > 5000 & n < 10000:
                    hra = (15 * Salary) / 100;
                    this.HRA = hra;
                    break;
                case double n when n > 10000 & n < 15000:
                    hra = (20 * Salary) / 100;
                    this.HRA = hra;
                    break;
                case double n when n > 15000 & n < 20000:
                    hra = (25 * Salary) / 100;
                    this.HRA = hra;
                    break;
                case double n when n >= 20000:
                    hra = (30 * Salary) / 100;
                    this.HRA = hra;
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }
        public void gethra()
        {
            Console.WriteLine("Employee HRA is: " + this.HRA);
        }
        public void setta()
        {
            double ta;
            switch (Salary)
            {
                case double n when n > 0 & n < 5000:
                    ta = (5 * Salary) / 100;
                    this.TA = ta;
                    break;
                case double n when n > 5000 & n < 10000:
                    ta = (10 * Salary) / 100;
                    this.TA = ta;
                    break;
                case double n when n > 10000 & n < 15000:
                    ta = (15 * Salary) / 100;
                    this.TA = ta;
                    break;
                case double n when n > 15000 & n < 20000:
                    ta = (20 * Salary) / 100;
                    this.TA = ta;
                    break;
                case double n when n >= 20000:
                    ta = (25 * Salary) / 100;
                    this.TA = ta;
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }
        public void getta()
        {
            Console.WriteLine("Employee TA is: " + this.TA);
        }
        public void setda()
        {
            double da;
            switch (Salary)
            {
                case double n when n > 0 & n < 5000:
                    da = (15 * Salary) / 100;
                    this.DA = da;
                    break;
                case double n when n > 5000 & n < 10000:
                    da = (20 * Salary) / 100;
                    this.DA = da;
                    break;
                case double n when n > 10000 & n < 15000:
                    da = (25 * Salary) / 100;
                    this.DA = da;
                    break;
                case double n when n > 15000 & n < 20000:
                    da = (30 * Salary) / 100;
                    this.DA = da;
                    break;
                case double n when n >= 20000:
                    da = (35 * Salary) / 100;
                    this.DA = da;
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
        }
        public void getda()
        {
            Console.WriteLine("Employee DA is: " + this.DA);
        }
        public void setgs()
        {
            double gs;
            gs = Salary + HRA + TA + DA;
            this.GrossSalary = gs;
        }
        public void getgs()
        {
            Console.WriteLine("Employee GrossSalary is :" + this.GrossSalary);
        }
        public virtual void calculatesalary()
        {
            double pf, tds, ns;
            pf = (10 * GrossSalary) / 100;
            this.PF = pf;
            tds = (18 * GrossSalary) / 100;
            this.TDS = tds;
            ns = GrossSalary - (PF + TDS);
            this.NetSalary = ns;
        }
        public void getcs()
        {
            Console.WriteLine("Employee PF is :" + PF);
            Console.WriteLine("Employee TDS is :" + TDS);
            Console.WriteLine("Employee NetSalary is :" + NetSalary);
        }
    }

    public class Manager : Employee
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double otherAllowance;
        private double Managergrosssalary;


        public void setpa()
        {
            double PA;
            PA = (8 * Salary) / 100;
            this.PetrolAllowance = PA;
        }
        public void getpa()
        {
            Console.WriteLine($"petrolAllowance is {this.PetrolAllowance}");
        }

        public void setfa()
        {
            double FA;
            FA = (13 * Salary) / 100;
            this.FoodAllowance = FA;
        }
        public void getfa()
        {
            Console.WriteLine($"FoodAllowance is {this.FoodAllowance}");
        }
        public void setoa()
        {
            double OA;
            OA = (3 * Salary) / 100;
            this.otherAllowance = OA;
        }
        public void getoa()
        {
            Console.WriteLine($"otherAllowance is {this.otherAllowance}");
        }

        public void setgrsl()
        {
            double Managergrosssalary;
            Managergrosssalary = PetrolAllowance + FoodAllowance + otherAllowance;
            this.Managergrosssalary = Managergrosssalary;
        }
        public void getgrsl()
        {
            Console.WriteLine("Manager GrossSalary is :" + this.Managergrosssalary);
        }

        public override void calculatesalary()
        {
            double pf, tds, ns;
            pf = (10 * Managergrosssalary) / 100;
            this.PF = pf;
            tds = (18 * Managergrosssalary) / 100;
            this.TDS = tds;
            ns = Managergrosssalary - (PF + TDS);
            this.NetSalary = ns;
        }
        public void getcalsal()
        {
            Console.WriteLine("Manager NetSalary is :" + NetSalary);
        }
    }

    public class MarketingExecutive : Employee
    {
        private double KilometerTravel;
        private double TourAllowances;
        private double TelephoneAllowances;
        private double grosssal;

        public void setta()
        {
            double TA;
            TA = (5 * Salary) / 100;
            this.TourAllowances = TA;
        }
        public void getta()
        {
            Console.WriteLine($"TourAllowances is {this.TourAllowances}");
        }

        public void settela()
        {
            double TelA;
            TelA = (1000 * Salary) / 100;
            this.TelephoneAllowances = TelA;
        }
        public void gettela()
        {
            Console.WriteLine($"TelephoneAllowances is {this.TelephoneAllowances}");
        }


        public void setgrsl()
        {
            double grosssal;
            grosssal = TourAllowances + TelephoneAllowances;
            this.grosssal = grosssal;
        }
        public void getgrsl()
        {
            Console.WriteLine("MarketingExecutive GrossSalary is :" + this.grosssal);
        }


        public override void calculatesalary()
        {
            double pf, tds, ns;
            pf = (10 * grosssal) / 100;
            this.PF = pf;
            tds = (18 * grosssal) / 100;
            this.TDS = tds;
            ns = grosssal - (PF + TDS);
            this.NetSalary = ns;
        }
        public void getcalsal()
        {
            Console.WriteLine("MarketingExecutive NetSalary is :" + NetSalary);
        }


    }
}