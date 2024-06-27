namespace Task_Interface_27._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department("ALIYEV MMC", 15);
            Employee employee = new Employee("Ismayil", 21, 4500);
            department.AddEmployee(employee);
            
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine($"Company Name: {department.Name}");
            Console.WriteLine($"Company Employee Limit:  {department.EmployeeLimit}");
            
            
        }
    }
}
