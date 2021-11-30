using Orchestra.Models;
using System;
using System.Text.RegularExpressions;

namespace Orchestra
{
    class Program
    {
        static void Main(string[] args)
        {

            RegexDemo1();
            ValidateCarRegistration();

            PlayOrchestra();


        }

        static void ValidateCarRegistration()
        {
            // Valid Example : "18D 12345" "18CN 456"
            // { 1,2} = minimum of 1 and maximum of 2 elements
            // ^ = start at beginning
            // $ = right up to end
            // (...)+ any number of elements inside
            //[A..Z] = capital letters only
            string pattern = @"^(\d){1,2}([A-Z]) (\d+)$";

            Match result = Regex.Match("1D 12345 blah", pattern);
            if (result.Success)
            {
                Console.Write("CarRegistration is valid");
            } else
            {

                Console.Write("CarRegistration is Invalid");

            }

        }


        static void RegexDemo1()
        {
            string pattern = @"^([a-zA-Z]+) (\d+)";

            Match result = Regex.Match("June 24", pattern);
            if (result.Success)
            {
                Console.Write("String is valid");
            }
            else
            {

                Console.Write("String is Invalid");

            }

        }

        static void PlayOrchestra()
        {
            Symphony symphony = new Symphony();

            symphony.instruments.Add(new StringInstrument("Guitar"));
            symphony.instruments.Add(new WoodwindInstrument("Clarinet"));
            symphony.instruments.Add(new PercussionInstrument("Drum"));
            symphony.instruments.Add(new BrassInstrument("Tuba"));

            symphony.Play();

        }



    }
}
