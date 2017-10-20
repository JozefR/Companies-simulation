namespace XA01
{
    public class Employee
    {
        public string Name { get; set; }
        public int DailyWage { get; set; }

        public Employee(string name, int dailyWage)
        {
            Name = name;
            DailyWage = dailyWage;
        }
    }
}
