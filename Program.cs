using System;
using System.Data.SqlClient;
namespace LektionAnas_Online221115
{
    //Struct

    struct Student1
    {
        private int _id;
        private string _name;

        public int ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public void PrintDetails()
        {
            Console.WriteLine($"ID = {_id}\nName = {_name}");
        }
    }

    struct book
    {
        public string title;
        public string author;
        public string subject;

        public void DisplayData()
        {
            Console.WriteLine($"Title : {title}\nAuthor: {author}\nSubject: {subject}");
        }
    }









    //SealedClass
    public sealed class User 
    {
        public string name = "Tobias Qlok";
        public string location = "Stockholm";

        public void GetInfo()
        {
            Console.WriteLine("Name : {0} ", name);
            Console.WriteLine("Location {0} ", location);
        }
    }

    public class Details 
    {
        public int age = 38;

        public void GetAge()
        {
            Console.WriteLine($"Age : {age}");
        }
    }

    //SealedMethod

    public class A
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Base Class A Method");
        }
        public virtual void Test()
        {
            Console.WriteLine("Base Class A Test Method");
        }
    }
    public class B : A
    {
        public override void GetInfo()
        {
            Console.WriteLine("Derived Class B Method ");
        }
        public override void Test()
        {
            Console.WriteLine("Derived class B test Method");
        }
    }

    public class C : B
    {
        public sealed override void GetInfo()
        {
            Console.WriteLine("Derived Class C Method ");
        }
        public sealed override void Test()
        {
            Console.WriteLine("Derived class C test Method");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Sealed Class
            //Details d = new Details();
            //d.GetAge();

            //User u = new User();
            //u.GetInfo();

            //Student1 SS1 = new Student1();
            //SS1.ID = 101;
            //SS1.Name = "Anas";
            //SS1.PrintDetails();

            book book1;
            book book2;
            book book3;

            //Book1
            book1.title = "The name of the wind";
            book1.author = "Patrick Rothfuss";
            book1.subject = "Fantasy";
            book1.DisplayData();


            //book2
            book2.title = "Hyperion";
            book2.author = "Dan Simmons";
            book2.subject = "Science-Fantasy";
            book2.DisplayData();

            //book3
            book3.title = "Brothers of the snake";
            book3.author = "unknown";
            book3.subject = "Warhammer 40K";
            book3.DisplayData();

            //Employee E1 = new Employee();

            //E1.FirstName = "Patrik";
            //E1.LastName = "Skattberg";
            //E1.Salary = 4214122.3;
            //E1.DisplayFullName();

            //PartialEmployee PEO = new PartialEmployee();
            //PEO.FirstName = "Anas";
            //PEO.LastName = "Qlok";
            //PEO.Salary = 132131.23;
            //PEO.DisplayFullName();

            //PEO.DisplayEmployeeData();


            //Student S1 = new Student();
            //S1.FirstName = "Leo";
            //S1.LastName = "Frid";

            //Console.WriteLine(S1.GetFullName());


            //PartialStudent PS = new PartialStudent();
            //PS.FirstName = "Patrik";
            //PS.LastName = "Skattberg";
            //Console.WriteLine(PS.GetFullName());

            Console.ReadKey();
        }
    }
}
