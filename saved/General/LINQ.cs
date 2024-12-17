// LINQ - Language Integrated Query, it is a query syntax used as a bridge between gap of world of data and world of objects

// LINQ can be used with -
// Objects, DataSet, XML, Entities, SQL

// We can work with LINQ either with the Method syntax or with Query syntax

// Pros of LINQ :
// Familiar language - You don't have to learn a new language for each type of data and resource.

// Less coding - LINQ reduces amount of code required compared to normal approach.

// Readability - LINQ makes code more readable.

// Standartization - The same LINQ syntax can be used to query multiple data resource.



// namespace LINQ
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee[] employees =
//             [
//                 new("Dave", "Marketing", 52, 10_000, [9, 9, 10]),
//                 new("Jon", "marketing", 44, 7000, [10, 8, 9]),
//                 new("Rick", "marketing", 38, 7000, [10, 8, 9]),
//                 new("Mike", "Marketing", 22, 5000, [6, 7, 9]),
//                 new("Jin", "Human Resources", 32, 3200, [8, 7, 6]),
//                 new("Richard", "Cleaning", 26, 1200, [3, 4, 5]),
//                 new("George", "Cleaning", 45, 1200, [3, 4, 5]),
//                 new("Rick", "Bulding Maintanance", 56, 2000, [8, 8, 9]),
//             ];

//             // SORTING ==================================

//             // List<Employee> sortedList =
//             // [
//             //     .. (
//             //         from emp in employees
//             //         orderby emp.Salary descending, emp.Age descending
//             //         select emp
//             //     ),
//             // ];

//             List<Employee> sortedList = [.. (employees.OrderBy((e) => e.Salary))];

//             foreach (Employee emp in sortedList)
//             {
//                 Console.WriteLine();
//                 Console.WriteLine($"NAME - {emp.Name}");
//                 Console.WriteLine($"SALARY - {emp.Salary}");
//                 Console.WriteLine();
//             }

//             // FILTERING ================================

//             // List<Employee> badLastAppEmployees =
//             // [
//             // .. (from emp in employees where emp.Appraisals[^1] < 8 select emp),
//             // ];

//             // List<Employee> badLastAppEmployees =
//             // [
//             //     .. (employees.Where((e) => e.Appraisals[^1] < 8)),
//             // ];

//             // Employee.DisplayEmployeeList(badLastAppEmployees);

//             // LINQ usage with Method syntax (old way below)
//             // List<Employee> filteredList = employees
//             //     .Where((e) => (e.Salary > 6000 && e.Age > 40) || e.Salary > 8000)
//             //     .ToList();

//             // LINQ usage with query syntax (old way below)
//             // List<Employee> filteredList = (
//             //     from emp in employees
//             //     where emp.Salary >= 6000 && emp.Age > 40
//             //     select emp
//             // ).ToList();

//             // Employee.DisplayEmployeeList(
//             //     filteredList,
//             //     "Employees with salary higher than 6000 and age higher than 40"
//             // );

//             // OLD WAY BELOW

//             // Display all employees
//             // Employee.DisplayEmployeeList(employees);

//             // Display employees with salary > 6000 and age > 40
//             // foreach (Employee emp in employees)
//             // {
//             // if (emp.Salary > 6000 && emp.Age > 40)
//             // {
//             // emp.GetInfo();
//             // }
//             // }

//             // Display employees with salary > 6000 and age > 40 or salary >= 8000
//             // foreach (Employee emp in employees)
//             // {
//             //     if ((emp.Salary > 6000 && emp.Age > 40) || emp.Salary > 8000)
//             //     {
//             //         emp.GetInfo();
//             //     }
//             // }
//         }
//     }

//     class Employee(string name, string job, int age, int salary, List<int> appraisals)
//     {
//         private List<int> _appraisals = appraisals;
//         public float AvaragePerformance { get; set; } = CalculateAvaragePerformance(appraisals);
//         public string Name { get; set; } = name ?? "Unkown";
//         public string Job { get; set; } = job ?? "Unkown";
//         public int Salary { get; set; } = salary;

//         public int Age { get; set; } = age;
//         public List<int> Appraisals
//         {
//             get => _appraisals;
//             set
//             {
//                 _appraisals = value;
//                 AvaragePerformance = CalculateAvaragePerformance(_appraisals);
//             }
//         }

//         private static float CalculateAvaragePerformance(List<int> appraisals)
//         {
//             int total = appraisals.Aggregate((acc, num) => acc + num);
//             return (float)total / appraisals.Count;
//         }

//         public static void DisplayEmployeeList(List<Employee> employees, string? filter = null)
//         {
//             if (filter != null)
//             {
//                 Console.ForegroundColor = ConsoleColor.Blue;
//                 Console.WriteLine(filter);
//                 Console.ResetColor();
//             }

//             foreach (Employee employee in employees)
//             {
//                 employee.GetInfo();
//             }
//         }

//         public void GetInfo()
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine();

//             Console.WriteLine($"NAME - {Name}");
//             Console.WriteLine($"JOB - {Job}");
//             Console.WriteLine($"AGE - {Age}");
//             Console.WriteLine($"SALARY - {Salary}");
//             Console.WriteLine($"AVARAGE PERFORMANCE - {AvaragePerformance}");

//             Console.WriteLine("APPRAISALS - ");
//             foreach (int app in _appraisals)
//             {
//                 Console.Write(app + " | ");
//             }

//             Console.ResetColor();
//             Console.WriteLine();
//         }
//     }
// }
