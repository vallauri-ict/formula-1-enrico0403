using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using ADOSQLServer2017_ns;
using System.Data;
using System.Data.SqlClient;

namespace FormulaOneWebFormProject
{
    public class clsDb
    {
        ADOSQLServer2017 ado;
        public clsDb(string nomeDb)
        {
            this.ado = new ADOSQLServer2017("C:/Dati/FormulaOne.mdf");
        }

        internal void visDati(bool what, GridView gwVisDati)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            string db = string.Empty;
            if(what==false)
            {
                db = "Teams";
            }
            else
            {
                db = "Drivers";
            }

            cmd.CommandText = "SELECT * FROM " + db + "WHERE ";
        }
    }
}