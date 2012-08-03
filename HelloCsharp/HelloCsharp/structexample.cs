using System;

namespace HelloCsharp
{
	//1. struct are value types, oppose to reference type, in stack and should no new!
	//2. struct cannot be derived from,
	//3. may not have parameterless constructor, have a default on, and initialize to zero.
	//4. all the constructors should have initialize all the fields
	//5. struct are passed by value. not reference!
	public struct A
	{
		public int m_id;

		public A(int a)
		{
			m_id = -1; //must init m_id, if have another field, init either
		}
	}



	public class structTest
	{
		public void  Struct_add(A a, A b)
		{
			A tmp;
			tmp.m_id = a.m_id + b.m_id;
			Console.WriteLine("a + b = " + tmp );
		}
	}

}

