using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class DbTools
    {
        public const string WORKINGPATH = @"C:\Users\Enrico Danni\Desktop\Formula1_Danni\formula-1-enrico0403\Dati\";
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+WORKINGPATH+@"FormulaOne.mdf;Integrated Security=True";

        private Dictionary<int, Driver> drivers;
        private Dictionary<string, Country> countries;
        private Dictionary<int, Team> teams;
        private Dictionary<int, Circuit> circuits;
        private Dictionary<int, Scores> scores;
        private Dictionary<int, Race> races;

        public Dictionary<int, Driver> Drivers { get => drivers; set => drivers = value; }
        public Dictionary<string, Country> Countries { get => countries; set => countries = value; }
        public Dictionary<int, Team> Teams { get => teams; set => teams = value; }
        public Dictionary<int, Circuit> Circuits { get => circuits; set => circuits = value; }
        public Dictionary<int, Scores> Scores { get => scores; set => scores = value; }
        public Dictionary<int, Race> Races { get => races; set => races= value; }

        public void ExecuteSqlScript(string sqlScriptName)
        {
            var fileContent = File.ReadAllText(WORKINGPATH + sqlScriptName);
            fileContent = fileContent.Replace("\r\n", "");
            fileContent = fileContent.Replace("\r", "");
            fileContent = fileContent.Replace("\n", "");
            fileContent = fileContent.Replace("\t", "");
            var sqlqueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            var con = new SqlConnection(CONNECTION_STRING);
            var cmd = new SqlCommand("query", con);
            con.Open(); int i = 0;
            foreach (var query in sqlqueries)
            {
                cmd.CommandText = query; i++;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException err)
                {
                    Console.WriteLine("Errore in esecuzione della query numero: " + i);
                    Console.WriteLine("\tErrore SQL: " + err.Number + " - " + err.Message);
                }
            }
            con.Close();
        }

        public void DropTable(string tableName)
        {
            var con = new SqlConnection(CONNECTION_STRING);
            var cmd = new SqlCommand("Drop Table " + tableName + ";", con);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                Console.WriteLine("\tErrore SQL: " + err.Number + " - " + err.Message);
            }
            con.Close();
        }

        public void GetTeams(bool forceReload = false)
        {
            if (forceReload || this.Teams == null)
            {
                this.Teams = new Dictionary<int, Team>();
                GetCountries();
                GetDrivers();
                var con = new SqlConnection(CONNECTION_STRING);
                using (con)
                {
                    SqlCommand command = new SqlCommand(
                      "SELECT * FROM Teams;",
                      con);
                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Team t = new Team(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            Countries[reader.GetString(3)],
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6),
                            Drivers[reader.GetInt32(7)],
                            Drivers[reader.GetInt32(8)],
                            reader.GetString(9),
                            reader.GetString(10)
                        );
                        this.Teams.Add(t.ID, t);
                    }
                    reader.Close();
                }
            }
        }

        public void GetCountries()
        {
            if (this.Countries == null)
            {
                this.Countries = new Dictionary<string, Country>();
                var con = new SqlConnection(CONNECTION_STRING);
                using (con)
                {
                    con.Open();
                    var command = new SqlCommand("SELECT * FROM Countries;", con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string countryIsoCode = reader.GetString(0);
                        Country c = new Country(countryIsoCode, reader.GetString(1));
                        this.Countries.Add(countryIsoCode, c);
                    }
                    con.Close();
                    con.Dispose();
                }
                SqlConnection.ClearAllPools();
            }
        }


        public void GetDrivers(bool forceReload = false)
        {
            this.GetCountries();
            if (forceReload || this.Drivers == null)
            {
                this.Drivers = new Dictionary<int, Driver>();
                var con = new SqlConnection(CONNECTION_STRING);
                using (con)
                {
                    con.Open();
                    var command = new SqlCommand("SELECT * FROM Drivers;", con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Driver d = new Driver(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetDateTime(3),
                            reader.GetString(4),
                            Countries[reader.GetString(5)],
                            reader.GetString(6),
                            reader.GetString(7)
                        );
                        this.Drivers.Add(d.ID, d);
                    }
                    con.Close();
                    con.Dispose();
                }
                SqlConnection.ClearAllPools();
            }
        }
        public void GetCircuits(bool forceReload = false)
        {
            if (forceReload || this.Circuits == null)
            {
                this.Circuits = new Dictionary<int, Circuit>();
                GetCountries();
                var con = new SqlConnection(CONNECTION_STRING);
                using (con)
                {
                    SqlCommand command = new SqlCommand(
                      "SELECT * FROM Circuits;",
                      con);
                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Circuit c = new Circuit(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            Countries[reader.GetString(4)],
                            reader.GetString(5),
                            reader.GetString(6)
                        );
                        this.Circuits.Add(c.ID, c);
                    }
                    reader.Close();
                }
            }
        }
        
        public void GetScores(bool forceReload = false)
        {
            if (forceReload || this.Scores == null)
            {
                this.Scores = new Dictionary<int, Scores>();
                var con = new SqlConnection(CONNECTION_STRING);
                using (con)
                {
                    SqlCommand command = new SqlCommand(
                      "SELECT * FROM Scores;",
                      con);
                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Scores s = new Scores(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetString(2)
                        );
                        this.Scores.Add(s.Pos, s);
                    }
                    reader.Close();
                }
            }
        }
        public void GetRaces(bool forceReload = false)
        {
            if (forceReload || this.Races == null)
            {
                this.Races = new Dictionary<int, Race>();
                GetCircuits();
                var con = new SqlConnection(CONNECTION_STRING);
                using (con)
                {
                    SqlCommand command = new SqlCommand(
                      "SELECT * FROM Races;",
                      con);
                    con.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Race r = new Race(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            Circuits[reader.GetInt32(2)],
                            reader.GetDateTime(3)
                        );
                        this.Races.Add(r.ID, r);
                    }
                    reader.Close();
                }
            }
        }
    }
}
