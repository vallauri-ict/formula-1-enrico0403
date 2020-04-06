using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

// using Microsoft.SqlServer.Management.Smo;

namespace FormulaOneDll
{
    public class DbTools
    {
        /*
        public void createCountriesWithSmo()
        {
            string sqlConnectionString = "connection string here";
            FileInfo file = new FileInfo(@"filepath to script.sql");
            string script = file.OpenText().ReadToEnd();
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            Server server = new Server(new ServerConnection(conn));
            try
            {
                server.ConnectionContext.ExecuteNonQuery(script);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.InnerException.Message);
            }

            file.OpenText().Close();
            conn.Close();
            Console.WriteLine("createCountries: SUCCESS!");
        }
        */

        public const string WORKINGPATH = @"C:\Dati\";
        public const string CONNSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + WORKINGPATH + "FormulaOne.mdf;Integrated Security=True";

        private Dictionary<string, Country> countries;
        private Dictionary<int, Driver> drivers;

        public void ExecuteSqlScript(string sqlScriptName)
        {
            var fileContent = File.ReadAllText(WORKINGPATH + sqlScriptName);
            fileContent = fileContent.Replace("\r\n", "");
            fileContent = fileContent.Replace("\r", "");
            fileContent = fileContent.Replace("\n", "");
            fileContent = fileContent.Replace("\t", "");
            var sqlqueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            var con = new SqlConnection(CONNSTR);
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
            var con = new SqlConnection(CONNSTR);
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

        public Dictionary<string, Country> GetCountries()
        {
            if (countries == null)
            {
                countries = new Dictionary<string, Country>();
                var con = new SqlConnection(CONNSTR);
                using (con)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Countries;", con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string countryIsoCode = reader.GetString(0);
                        Country country = new Country(countryIsoCode, reader.GetString(1));
                        countries.Add(countryIsoCode, country);
                    }
                    reader.Close();
                }
            }
            return countries;
        }

        public Dictionary<int, Driver> GetDrivers(bool forceReaload = false)
        {
            if (drivers == null || forceReaload)
            {
                drivers = new Dictionary<int, Driver>();
                var con = new SqlConnection(CONNSTR);
                using (con)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Drivers;", con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int driverId = reader.GetInt32(0);
                        Driver driver = new Driver(
                            driverId,
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetDateTime(3),
                            reader.GetString(4),
                            GetCountries()[reader.GetString(5)]
                        );
                        drivers.Add(driverId, driver);
                    }
                    reader.Close();
                }
            }
            return drivers;
        }

        public DataTable GetDriversTable()
        {
            DataTable driversTable = new DataTable();
            var con = new SqlConnection(CONNSTR);
            using (con)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Drivers;", con);
                con.Open();
                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(driversTable);
                con.Close();
                da.Dispose();
            }
            return driversTable;
        }

        public List<Team> LoadTeams()
        {
            List<Team> retVal = new List<Team>();
            var con = new SqlConnection(CONNSTR);
            using (con)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT * FROM Teams;",
                  con);
                con.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string teamCountryCode = reader.GetString(3);
                    // Country teamCountry = GetCountries().Find(item => item.CountryCode == teamCountryCode);
                    Country teamCountry = GetCountries()[teamCountryCode];
                    Driver firstDriver = GetDrivers()[reader.GetInt32(7)];
                    Driver secondDriver = GetDrivers()[reader.GetInt32(8)];
                    Team team = new Team(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        teamCountry,
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        firstDriver,
                        secondDriver
                    );
                    retVal.Add(team);
                }
                reader.Close();
            }
            return retVal;
        }
    }
}
