using System;

//add and interface class just for example
namespace HelloCsharp
{
    //comment: interface can have methods, properties, and events
    public interface IInterface
    {
        void Play();
        void Stop();
        void Pause();
        double CurrentTime{get;}
    }
}

