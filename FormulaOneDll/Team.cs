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
        private string logo;
        private string img;

        public Team(int id, string name, string fullTeamName, Country country, string powerUnit, string technicalChief, string chassis, Driver firstDriver, Driver secondDriver, string logo, string img)
        {
            this.id = id;
            this.name = name;
            this.fullTeamName = fullTeamName;
            this.country = country;
            this.powerUnit = powerUnit;
            this.technicalChief = technicalChief;
            this.chassis = chassis;
            this.firstDriver = firstDriver;
            this.secondDriver = secondDriver;
            this.logo = logo;
            this.img = img;
        }

        public int ID
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

        public string Logo { get => logo; set => logo = value; }
        public string Img { get => img; set => img = value; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
