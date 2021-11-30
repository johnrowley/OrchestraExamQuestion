using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra.Models
{
    public class Symphony
    {

        public Symphony()
        {

        }

        public List<MusicalInstrument> instruments = new List<MusicalInstrument>();

        public void Play()
        {

            foreach(MusicalInstrument mi in instruments)
            {
                string message = mi.Play();

                Console.WriteLine(message);
            }
        }
    }
}
