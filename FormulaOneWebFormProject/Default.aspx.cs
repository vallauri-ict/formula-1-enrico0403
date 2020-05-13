using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FormulaOneDll;

namespace FormulaOneWebFormProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLoadCountry_Click(object sender, EventArgs e)
        {
            DbTools db = new DbTools();
            db.GetCountries();
            GridView2.DataSource = db.Countries.Values;
            //GridView1.data
            GridView2.DataBind();
        }

        protected void btnLoadTeam_Click(object sender, EventArgs e)
        {
            DbTools db = new DbTools();
            db.GetTeams();
            GridView1.DataSource = db.Teams.Values;
            //GridView1.data
            GridView1.DataBind();
        }

        protected void btnLoadDriver_Click(object sender, EventArgs e)
        {
            DbTools db = new DbTools();
            db.GetDrivers();
            GridView3.DataSource = db.Drivers.Values;
            //GridView1.data
            GridView3.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Attaching one onclick event for the entire row, so that it will
                // fire SelectedIndexChanged, while we click anywhere on the row.
                e.Row.Attributes["onclick"] =
                  ClientScript.GetPostBackClientHyperlink(this.GridView1, "Select$" + e.Row.RowIndex);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbTools db = new DbTools();
            db.GetTeams();
            GridView table= (GridView)sender;
            int rowIndex = Convert.ToInt32(table.SelectedRow.Cells[0].Text);
            GridView2.DataSource = db.Teams[rowIndex].FirstDriver.ToDataTable();
            GridView2.DataBind();
            GridView3.DataSource = db.Teams[rowIndex].SecondDriver.ToDataTable();
            GridView3.DataBind();
        }
    }
}