using System;

namespace HelloCsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello CSharp!");
            Operation op = new Operation();
            Console.WriteLine("20 + 10 = " + op.Addition(20, 10));
            Console.WriteLine("20 x 10 = " + op.Multiply(20, 10));
            Console.WriteLine("20 - 10 = " + op.Substraction(20, 10));
            Console.WriteLine("20 / 10 = " + op.Division(20, 10));

            Student stud = new Student();
            stud.PrintStudentInfo();

            Console.WriteLine("Merge test to master!");
            Console.WriteLine("try to develop in monodevelop!");
        }
    }

    class Operation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Substraction(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
