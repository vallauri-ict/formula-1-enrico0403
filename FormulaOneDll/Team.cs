using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Team
    {
        private int id;
        private string name;
        private string fullTeamName;
        private Country country;
        private string powerUnit;
        private string technicalChief;
        private string chassis;
        private Driver firstDriver;
        private Driver secondDriver;

        public Team(int id, string name, string fullTeamName, Country country, string powerUnit, string technicalChief, string chassis, Driver firstDriver, Driver secondDriver)
        {
            this.Id = id;
            this.Name = name;
            this.FullTeamName = fullTeamName;
            this.Country = country;
            this.PowerUnit = powerUnit;
            this.TechnicalChief = technicalChief;
            this.Chassis = chassis;
            this.FirstDriver = firstDriver;
            this.SecondDriver = secondDriver;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string FullTeamName
        {
            get
            {
                return fullTeamName;
            }

            set
            {
                fullTeamName = value;
            }
        }

        public Country Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string PowerUnit
        {
            get
            {
                return powerUnit;
            }

            set
            {
                powerUnit = value;
            }
        }

        public string TechnicalChief
        {
            get
            {
                return technicalChief;
            }

            set
            {
                technicalChief = value;
            }
        }

        public string Chassis
        {
            get
            {
                return chassis;
            }

            set
            {
                chassis = value;
            }
        }

        public Driver FirstDriver
        {
            get
            {
                return firstDriver;
            }

            set
            {
                firstDriver = value;
            }
        }

        public Driver SecondDriver
        {
            get
            {
                return secondDriver;
            }

            set
            {
                secondDriver = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
