using System;

namespace HelloCsharp
{
    //derivedclass
    public class SubVertex3D :Vertex3D
    {
        public SubVertex3D ():base()
        {
        }

        private const string name = "SubVertex3D";

        //override a method of base class
        public override void PrintVersionInfo()
        {
            Console.Write("\n");
            Console.WriteLine("|---- SubCertex3D version !----- |");
            Console.WriteLine("| version : " + name + " " + ver + "." + subver);
            Console.WriteLine("|---- SubCertex3D version end!---|");
            Console.Write("\n");
        }

        //override a method of none-virtual functions
        //usecase: There may be cases where you need to derive a class from 
        //a third-party library and you want to override one
        //method, but it was not declared as virtualin the base class.
        public new void PrintInfo()
        {
            Console.Write("\n");
            Console.WriteLine("|-----override none-virtual Certex3D information   !-----|");
            Console.Write("\n");

        }

    }
}

