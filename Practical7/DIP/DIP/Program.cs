using System.Reflection;

namespace DIP
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum Position
    {
        Administrator,
        Manager,
        Executive
    }

    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var empManager = new EmployeeManager();
            empManager.AddEmployee(
                new Employee
                {
                    Name = "Krupa",
                    Gender = Gender.Female,
                    Position = Position.Manager
                }
            );
            empManager.AddEmployee(
                new Employee
                {
                    Name = "Jainam",
                    Gender = Gender.Male,
                    Position = Position.Administrator
                }
            );
            var stats = new EmployeeStatistics(empManager);
            Console.WriteLine(
                $"Number of female managers in our company is: {stats.CountFemaleManagers()}"
            );
        }
    }

    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;

        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }

        public int CountFemaleManagers() =>
            _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }

    public class EmployeeManager : IEmployeeSearchable
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(
            Gender gender,
            Position position
        ) => _employees.Where(emp => emp.Gender == gender && emp.Position == position);
    }

    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
