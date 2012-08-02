using System;

namespace HelloCsharp
{
    public class Student
    {
        public Student ()
        {
        }

        private int index = 1000;
        private string name = "Leo";

        public void PrintStudentInfo()
        {
            Console.Write("\n");
            Console.WriteLine("|-----------begin-----------|");
            Console.WriteLine("| Student infomation: " + Id + " " + name + " " + Address);
            Console.WriteLine("|-----------end  -----------|");
            Console.Write("\n");
        }
        //Init properties when at construction step 1
        //these properties is not initialized!
        public int Id {set;get;}
        public string Name {set;get;}
        public string Address{set;get;}
    }
}

