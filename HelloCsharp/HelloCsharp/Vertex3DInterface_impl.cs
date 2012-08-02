using System;

namespace HelloCsharp
{
    public class Vertex3DInterface_impl:IInterface
    {
        private double current;
        public Vertex3DInterface_impl()
        {
        }

        public void Play()
        {
            Console.WriteLine("Vertex3DInterface_impl Play!");
        }
        public void Pause()
        {
            Console.WriteLine("Vertex3DInterface_impl Pause!");
        }

        public void Stop()
        {
            Console.WriteLine("Vertex3DInterface_impl stop!");
        }

        public double CurrentTime
        {
            get{ return current;}
        }
    }
}

