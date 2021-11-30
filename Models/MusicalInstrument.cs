using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchestra.Models
{
    public abstract class MusicalInstrument
    {
        public string Name { get; set; }

        public string Section { get; set; }

        public string Play()
        {

            return $"{Name} is playing from the {Section} section";

        }

        //public MusicalInstrument(string _section)
        //{
        //    Section = _section;
        //}
    }

    public class StringInstrument : MusicalInstrument
    {
        public StringInstrument(string _name)
        {
            Name = _name;
            Section = "String";
        }
    }

    public class WoodwindInstrument : MusicalInstrument
    {
        public WoodwindInstrument(string _name)
        {
            Name = _name;
            Section = "Woodwind";
        }
    }

    public class BrassInstrument : MusicalInstrument
    {
        public BrassInstrument(string _name)
        {
            Name = _name;
            Section = "Brass";
        }
    }

    public class PercussionInstrument : MusicalInstrument
    {
        public PercussionInstrument(string _name)
        {
            Name = _name;
            Section = "Percussion";
        }
    }


}
