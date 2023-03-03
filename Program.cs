using System;
namespace CSharp
{

    class Empoloyee
    {
        public string FirstName;
        public string LastName;

        public int Age;
        public float salary;



        public void PrintFullNameandAge()
        {
            System.Console.WriteLine(FirstName + " " + LastName + " " + "Age is: " + Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("This is the test file");
            System.Console.WriteLine("Hi Team, I have created this repository to work on.");
            System.Console.WriteLine("One more statement");

            Empoloyee E = new Empoloyee();
            E.FirstName = "IE";
            E.LastName = "Team";
            E.Age = 23;
            E.PrintFullName();
        }
    }
}