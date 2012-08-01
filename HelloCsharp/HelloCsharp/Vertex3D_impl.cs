using System;

//try to implement the partial
namespace HelloCsharp
{
	//partial class
	public partial class Vertex3D
	{
		//public method
		public void PrintInternalValue()
		{
			Console.WriteLine( "the internal value is: " + internal_x);
		}
		//private method
		private void PrivateInfo()
		{
			Console.WriteLine("Vertex3D private information!");
		}
		//internal method, THIS IS DEFAULT IF NOTHING IS DEFINED!
		internal void InternalInfo()
		{
			Console.WriteLine("Vertex3D internal infomation!");
		}
		//protected method
		protected void ProtectedInfo()
		{
			Console.WriteLine("Vertex3D protected information!");
		}
		//proteced internal method
		protected internal void protectedInternalInfo()
		{
			Console.WriteLine("Vertex3D proteced internal method!");
		}

	}
}

