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
			Console.WriteLine("Student infomation: " + index + " " + name);
		}
	}
}

