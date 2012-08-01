using System;

//new a class
namespace HelloCsharp
{
	public partial class Vertex3D
	{
		//constructor,public
		public Vertex3D ()
		{
		}
		//define a method
		public void PrintInfo()
		{
			Console.WriteLine("Certex3D information!");
		}

		//define a member
		private int _x;
		private int _y;
		internal int internal_x = 100;

		//define a property
		public int X
		{
			get {return _x;}
			set {_x = value;}
		}
	}
}

