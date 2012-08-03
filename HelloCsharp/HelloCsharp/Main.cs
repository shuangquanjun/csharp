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
            
            //Init properties when at construction step 2
            Student p = new Student() 
                    { Id = 1, Name = "Ben", Address = "Redmond, WA" };
            p.PrintStudentInfo();

            Console.WriteLine("Merge test to master!");
            Console.WriteLine("try to develop in monodevelop!");
            Console.WriteLine("edit in github code editor!");

            //call the static function
            Vertex3D v3d_add = new Vertex3D();
            Vertex3D v3d_a   = new Vertex3D(10,20);
            Vertex3D v3d_b   = new Vertex3D(20,30);
            v3d_add = Vertex3D.Add(v3d_a, v3d_b);
            v3d_add.PrintInfo();
			v3d_add.ToString();
            v3d_add.PrintVersionInfo();

            SubVertex3D sv3d = new SubVertex3D();
            sv3d.PrintVersionInfo();
            sv3d.PrintInfo();

			Vertex3DInterface_impl v3dInf = new Vertex3DInterface_impl();
			Console.WriteLine("\n|*************************************|");
			v3dInf.Play();
			v3dInf.Pause();
			v3dInf.Stop();
			Console.WriteLine("|*************************************|\n");

			//test stuct operation
			A a, b;
			a.m_id = 100;
			b.m_id = 200;
			structTest st = new structTest();
			st.Struct_add(a,b);

			//test a anonymous class
			var var1 = new { id = 1, name = "XXXX"};
			Console.WriteLine("\n|------------test var class------------------|");
			Console.WriteLine("the index is {0}.", var1.id);
			Console.WriteLine("the name  is {0}.", var1.name);
			Console.WriteLine("|------------test var class------------------|\n");
        	


			TestAbstractClass tac = new TestAbstractClass();
			tac.Test();
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
