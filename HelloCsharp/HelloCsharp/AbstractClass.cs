using System;

namespace HelloCsharp
{
	//define an abstract class
	public abstract class AbstractClass
	{
		public AbstractClass ()
		{
		}

		public abstract void AbstractMethod1();
			//{} abstract method should not have body;
		public virtual void AbstractMethod2()
		{

		}
	}
	public class SubAbstractClass : AbstractClass
	{
		override public void AbstractMethod1()
		{
			Console.WriteLine( "SubAbstractClass' AbstractMethod1");
		}

		override public void AbstractMethod2()
		{
			Console.WriteLine( "SubAbstractClass' AbstractMethod2");
		}
	}



	public class TestAbstractClass
	{

		public void Test()
		{
			//AbstractClass ac = new AbstractClass();//can not new an abstract class
			SubAbstractClass sac = new SubAbstractClass();
			sac.AbstractMethod2();

		}

	}
}

