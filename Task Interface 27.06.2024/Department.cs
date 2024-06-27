

using System.Security.Cryptography.X509Certificates;

namespace Task_Interface_27._06._2024
{
    public class Department
    {
        public string Name { get; set; }    
        public int EmployeeLimit { get; set; }
        public Employee[] employees;
        public Department(string name, int employeelimit)
        {
                Name = name;
                EmployeeLimit = employeelimit;
            employees = new Employee[0];        
        }
        public void AddEmployee(Employee employee)
        {
            if (employees.Length >= EmployeeLimit)
                throw new CapacityLimitException("Out of Limit");
           
            Array.Resize(ref employees, employees.Length +1);
            employees[employees.Length - 1] = employee;
             
        }
        public Employee this[int i] 
        {
            get { return employees[i]; }
            set { employees[i] = value; }
        }
        
    }
}
