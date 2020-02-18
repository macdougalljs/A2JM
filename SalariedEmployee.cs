namespace A2JeremiahMacDougall
{
    class SalariedEmployee : Employee
    {
        public double Salary { get; private set; }
        public SalariedEmployee(string name, EmployeeType et, double salary) : base(name, et)
        {
            Salary = salary;
        }

        public override double GrossEarnings { get { return Salary; } }
    }
}
