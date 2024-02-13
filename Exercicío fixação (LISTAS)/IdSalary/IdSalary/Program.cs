using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course {
    class IdSalary {
        static void Main(string[] args) {

            int N, id;
            double Percentage;

            Employee employee;

            List<Employee> listEmployees = new List<Employee>();
            List<int> checkId = new List<int>();

            Console.Write("How many employess will be registered? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                while (true) {
                    id = int.Parse(Console.ReadLine());
                    if (!checkId.Contains(id)) {
                        break;
                    } else {
                        Console.WriteLine("ID already exists. Please enter a different ID.");
                    }
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee = new Employee(id, name, salary);
                    checkId.Add(employee.Id);
                    listEmployees.Add(employee);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Enter the employee ID that will have salary increase: ");
            N = int.Parse(Console.ReadLine());
            Employee n1 = listEmployees.Find(x => x.Id == N);
                if (n1 != null) {
                    Console.Write("Enter the porcentage: ");
                    Percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    n1.IncreaseSalary(Percentage);
                } else {
                    Console.WriteLine("This ID does not exist!");
                }
            Console.WriteLine();
            Console.WriteLine("Uptaded list of employees: ");
            foreach (Employee obj in listEmployees) {
                Console.WriteLine(obj);
            }
        }
    }
}
