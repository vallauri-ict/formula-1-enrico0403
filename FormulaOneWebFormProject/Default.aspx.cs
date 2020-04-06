using System;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;

using FormulaOneDll;

namespace FormulaOneWebFormProject
{
    public partial class Default : System.Web.UI.Page
    {
        clsDb db;
        public bool what = false;
        // True = drivers
        // False = teams
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // no init needed
            }
            gwVisDati.Visible = false;
        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            GridView1.AutoGenerateSelectButton = false;
            DbTools dbTools = new DbTools();
            GridView1.DataSource = dbTools.GetCountries().Values;
            GridView1.DataBind();
        }

        protected void btnLoadDrivers_Click(object sender, EventArgs e)
        {
            what = true;
            GridView1.AutoGenerateSelectButton = true;
            DbTools dbTools = new DbTools();
            // GridView1.DataSource = dbTools.GetDrivers().Values;
            GridView1.DataSource = dbTools.GetDriversTable();
            GridView1.DataBind();
        }

        protected void btnLoadTeams_Click(object sender, EventArgs e)
        {
            what = false;
            GridView1.AutoGenerateSelectButton = true;
            DbTools dbTools = new DbTools();
            GridView1.DataSource = dbTools.LoadTeams();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = gwVisDati.SelectedIndex;
            db = new clsDb("C:/Dati/FormulaOne.mdf");
            db.visDati(what, gwVisDati);
        }
    }
}