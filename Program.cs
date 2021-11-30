using Orchestra.Models;
using System;

namespace Orchestra
{
    class Program
    {
        static void Main(string[] args)
        {
            Symphony symphony = new Symphony();

            symphony.instruments.Add(new StringInstrument ( "Guitar"));
            symphony.instruments.Add(new WoodwindInstrument ("Clarinet"));
            symphony.instruments.Add(new PercussionInstrument( "Drum" ));
            symphony.instruments.Add(new BrassInstrument ("Tuba"));

            symphony.Play();
        }
    }
}
