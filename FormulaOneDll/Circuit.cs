using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Circuit
    {
        private int id;
        private string name;
        private int length;
        private int nLaps;
        private Country country;
        private string recordLap;
        private string img;

        public Circuit(int id, string name, int length, int nLaps, Country country, string recordLap, string img)
        {
            this.id = id;
            this.name = name;
            this.length = length;
            this.nLaps = nLaps;
            this.country = country;
            this.recordLap = recordLap;
            this.img = img;
        }

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Length { get => length; set => length = value; }
        public int NLaps { get => nLaps; set => nLaps = value; }
        public Country Country { get => country; set => country = value; }
        public string RecordLap { get => recordLap; set => recordLap = value; }
        public string Img { get => img; set => img = value; }
    }
}
