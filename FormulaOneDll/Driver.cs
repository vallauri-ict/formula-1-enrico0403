using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Driver
    {
        #region Attributes
        private readonly int id;
        private string firstname;
        private string lastname;
        private DateTime dob;
        private string placeOfBirthday;
        private Country country;
        #endregion

        #region Constructors
        public Driver(int id) { this.id = id; }

        public Driver(int id, string firstname, string lastname, DateTime dob, string placeOfBirthday, Country country) : this(id)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Dob = dob;
            this.PlaceOfBirthday = placeOfBirthday;
            this.Country = country;
        }
        #endregion

        #region Properties
        public int ID { get => id; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string PlaceOfBirthday { get => placeOfBirthday; set => placeOfBirthday = value; }
        public Country Country { get => country; set => country = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{this.Firstname} {this.lastname}";
        public DataTable ToDataTable()
        {
            DataTable dt = new DataTable(this.Firstname);
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Firstname", typeof(string));
            dt.Columns.Add("Lastname", typeof(string));
            dt.Columns.Add("DOB", typeof(DateTime));
            dt.Columns.Add("PlaceOfBirth", typeof(string));
            dt.Columns.Add("Country", typeof(string));

            dt.Rows[0]["id"] = this.ID.ToString();
            dt.Rows[0]["Firstname"] = this.Firstname;
            dt.Rows[0]["Lastname"] = this.Lastname;
            dt.Rows[0]["DOB"] = this.dob.ToShortDateString();
            dt.Rows[0]["PlaceOfBirth"] = this.PlaceOfBirthday;
            dt.Rows[0]["Country"] = this.Country.ToString();

            return dt;
        }
        #endregion
    }
}
