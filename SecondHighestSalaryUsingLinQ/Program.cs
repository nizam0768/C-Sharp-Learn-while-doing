public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Ali", Salary = 5000 },
            new Employee { Id = 2, Name = "Sara", Salary = 7000 },
            new Employee { Id = 3, Name = "Nizam", Salary = 6000 },
            new Employee { Id = 4, Name = "Aditya", Salary = 7000 }, // duplicate highest
            new Employee { Id = 5, Name = "John", Salary = 4000 }
        };

        var secondHighest = employees.Select(e => e.Salary).Distinct().OrderByDescending(s => s).Skip(1).FirstOrDefault();
        Console.WriteLine(secondHighest);

        // Approach using loop

        int higest = int.MinValue;
        int secondHigest = int.MaxValue;

        foreach(Employee emp in employees)
        {
            if(emp.Salary > higest)
            {
                secondHighest = higest;
                higest = emp.Salary;
            }
            else if(emp.Salary > secondHighest && emp.Salary < higest)
            {
                secondHighest = emp.Salary;
            }
        }
        Console.WriteLine("---Approch 2------");
        Console.WriteLine("Second Highest Val: " + secondHighest);
    }
}