namespace UdemyEfCore.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    public class ParttimeEmployee : Employee
    {
        public decimal DailyWage { get; set; }
    }

    public class FulltimeEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
    }
}
