namespace A2JeremiahMacDougall
{
    class HourlyEmployee : Employee
    {
        private int _hours;
        private double _hourlyWage;

        public override double GrossEarnings
        {
            get
            {
                if (HoursWorked <= 40)
                    return HoursWorked * HourlyWage;
                else
                    return (40 * HourlyWage) + (HoursWorked - 40) * HourlyWage * 1.5;
            }
        }
        public int HoursWorked { get { return this._hours; } private set { this._hours = value; } }
        public double HourlyWage { get { return this._hourlyWage; } private set { this._hourlyWage = value; } }

        public HourlyEmployee(string name, EmployeeType et, int hours, double wage) : base(name, et)
        {
            HoursWorked = hours;
            HourlyWage = wage;
        }
    }
}
