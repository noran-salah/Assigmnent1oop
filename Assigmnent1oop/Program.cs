//using System.Globalization;

//namespace Company
//{
                    
          
    
//        public enum SecurityLevel
//        {
//            Guest,
//            Developer,
//            Secretary,
//            DBA
//        }

//        public class Employee
//        {
//            // Properties
//            public int ID { get; private set; }
//            public string Name { get; private set; }
//            public SecurityLevel Security { get; set; }
//            private decimal salary;
//            public DateTime HireDate { get; private set; }
//            private char gender;

//            // Gender property with restriction
//            public char Gender
//            {
//                get => gender;
//                set
//                {
//                    if (value == 'M' || value == 'F')
//                        gender = value;
//                    else
//                        throw new ArgumentException("Gender must be 'M' or 'F'.");
//                }
//            }

//            // Salary property
//            public decimal Salary
//            {
//                get => salary;
//                set
//                {
//                    if (value < 0)
//                        throw new ArgumentException("Salary cannot be negative.");
//                    salary = value;
//                }
//            }

//            // Constructor
//            public Employee(int id, string name, SecurityLevel security, decimal salary, DateTime hireDate, char gender)
//            {
//                ID = id;
//                Name = name ?? throw new ArgumentNullException(nameof(name));
//                Security = security;
//                Salary = salary;
//                HireDate = hireDate;
//                Gender = gender;
//            }

//            // Override ToString method
//            public override string ToString()
//            {
//                return $"ID: {ID}, Name: {Name}, Security Level: {Security}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate:yyyy-MM-dd}, Gender: {Gender}";
//            }
//        }

//        class Program
//        {
//            static void Main(string[] args)
//            {
//                try
//                {
//                    // Example usage
//                    Employee employee = new Employee(1, "John Doe", SecurityLevel.Developer, 75000m, new DateTime(2020, 5, 10), 'M');
//                    Console.WriteLine(employee);

//                    Employee employee2 = new Employee(2, "Jane Smith", SecurityLevel.Secretary, 50000m, new DateTime(2021, 7, 15), 'F');
//                    Console.WriteLine(employee2);
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Error: {ex.Message}");
//                }
//            }
//        }
//    }


    

