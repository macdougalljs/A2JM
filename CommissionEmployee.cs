namespace A2JeremiahMacDougall
{
    public class CommissionEmployee : Employee
    {
        public override double GrossEarnings { get { return CommissionRate / 100 * GrossSales; } }
        public double GrossSales { get; private set; }
        public double CommissionRate { get; private set; }

        // in here I'll need to setup of the contructor for the ComissionEmployee

        public CommissionEmployee(string name, EmployeeType et, double gr, double cr) : base(name, et)
        {
            CommissionRate = cr;
            GrossSales = gr;
        }
    }
}
