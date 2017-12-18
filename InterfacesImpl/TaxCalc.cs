namespace InterfacesImpl
{
    public class TaxCalc : ITaxCalculator
    {
        double Salary;
        int Tenure;
        int SalaryDays;
        int NumberOfWorkingDays;

        public TaxCalc(double salary, int tenure, int salarydays, int WorkingDays)
        {
            this.Salary = salary;
            this.Tenure = tenure;
            this.SalaryDays = salarydays;
            this.NumberOfWorkingDays = WorkingDays;
        }
        public double Calculate()
        {
            double gratuity = (Salary * Tenure * SalaryDays) / NumberOfWorkingDays;
            return gratuity;
        }
    }
}