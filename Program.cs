using System;

namespace LektionAnas_Online221115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee();

            E1.FirstName = "Patrik";
            E1.LastName = "Skattberg";
            E1.Salary = 4214122.3;
            E1.DisplayFullName();

            PartialEmployee PEO = new PartialEmployee();
            PEO.FirstName = "Anas";
            PEO.LastName = "Qlok";
            PEO.Salary = 132131.23;
            PEO.DisplayFullName();

            PEO.DisplayEmployeeData();


            Student S1 = new Student();
            S1.FirstName = "Leo";
            S1.LastName = "Frid";

            Console.WriteLine(S1.GetFullName());


            PartialStudent PS = new PartialStudent();
            PS.FirstName = "Patrik";
            PS.LastName = "Skattberg";
            Console.WriteLine(PS.GetFullName());

            Console.ReadKey();
        }
    }
}
