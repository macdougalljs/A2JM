namespace A2JeremiahMacDougall
{
    public enum EmployeeType
    {
        Hourly, Salaried, Commission
    }
    public abstract class Employee
    {
        public string Name { get; private set; }


        public EmployeeType TypeOfEmployee { get; private set; }


        // c.	A readonly property Tax, that calculates and returns the 20% tax. 
        public double Tax { get { return GrossEarnings * 0.20; } }
        public double NetEarnings { get { return GrossEarnings - Tax; } }

        // b.	An abstract readonly property GrossEarnings. This property is implemented in each derived class to calculate the earnings of each type of employee. 
        public abstract double GrossEarnings { get; }

        public Employee(string name, EmployeeType et)
        {
            this.Name = name;
            this.TypeOfEmployee = et;
        }

        public override string ToString()
        {
            return $"Name: {Name} /nType Of Employee: {TypeOfEmployee}";
        }
    }
}
