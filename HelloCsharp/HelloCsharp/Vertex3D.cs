using System;

//new a class
namespace HelloCsharp
{
    public partial class Vertex3D
    {
        //constructor,public
        public Vertex3D ()
        {
            ver = 0; 
        }
        //Define another 
        public Vertex3D(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        //using readonly and const field
        public virtual void PrintVersionInfo()
        {
            Console.Write("\n");
            Console.WriteLine("|----Certex3D version !----- |");
            Console.WriteLine("| version : " + name + " " + ver + "." + subver);
            Console.WriteLine("|----Certex3D version end!---|");
            Console.Write("\n");
        }

        //define a method
        public void PrintInfo()
        {
            Console.Write("\n");
            Console.WriteLine("|-----Certex3D information   !-----|");
            Console.WriteLine("| :x = "+ this._x);
            Console.WriteLine("| :y = "+ this._y);
            PartialMethod();
			Console.WriteLine("|-----Certex3D information end!----|");
            Console.Write("\n");

        }

        //define a member
        private int _x = 0;
        private int _y;
        internal int internal_x = 100;

        //init the static field inline
        private static int _numInstance = 30;

        //--use const and readonly
        //--const and readonly define data that does not change,but CONST must be defined at declaration,
        private const string name = "Vertex3D";
        //--readonly can be set at declaration or in constructor!
        protected readonly int ver;
        protected readonly int subver = 1;


        //define a property
        public int X
        {
            get {return _x;}
            set {_x = value;}
        }

        public int Y
        {
            get {return _y;}
            set {_y = value;}
        }

        //static function class.
        public static Vertex3D Add(Vertex3D a, Vertex3D b)
        {
            Vertex3D ret = new Vertex3D();
            ret.X = a.X + b.X;
            ret.Y = a.Y + b.Y;

            return ret;
        }

		//partial method can only be private
		partial void PartialMethod();
    }
}

