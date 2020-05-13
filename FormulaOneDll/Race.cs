using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Race
    {
        private int id;
        private string name;
        private Circuit circuit;
        private DateTime date;

        public Race(int id, string name, Circuit circuit, DateTime date)
        {
            this.ID = id;
            this.Name = name;
            this.Circuit = circuit;
            this.Date = date;
        }

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Circuit Circuit { get => circuit; set => circuit= value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
