using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FormulaOneDll;

namespace FormulaOneCrudFormProject
{
    public partial class FormMain : Form
    {
        DbTools db;
        BindingList<Team> teams;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            db = new DbTools();
            db.GetTeams();
            //teams = new BindingList<Team>(db.Teams);
            
            listBoxTeam.DataSource = teams;

            cmbCountry.DataSource = new BindingSource(db.Countries, null);
            cmbCountry.DisplayMember = "Value";
            cmbCountry.ValueMember = "Key";

            cmbFirstDriver.DataSource = new BindingSource(db.Drivers, null);
            cmbFirstDriver.DisplayMember = "Value";
            cmbFirstDriver.ValueMember = "Key";

            cmbSecondDriver.DataSource = new BindingSource(db.Drivers, null);
            cmbSecondDriver.DisplayMember = "Value";
            cmbSecondDriver.ValueMember = "Key";
        }

        private void listBoxTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            Team sel = (Team)listBoxTeam.SelectedItem;
            txtFullTeamName.Text = sel.FullTeamName;
            cmbCountry.SelectedValue = sel.Country.CountryCode;
            txtPowerUnit.Text = sel.PowerUnit;
            txtTechnicalChief.Text = sel.TechnicalChief;
            txtChassis.Text = sel.Chassis;
            cmbFirstDriver.SelectedValue = sel.FirstDriver.ID;
            cmbSecondDriver.SelectedValue = sel.SecondDriver.ID;
        }

        private void stampaToolStripTeamButton_Click(object sender, EventArgs e)
        {
            Utils.SerializeToCsv(teams, @".\Teams.csv");

            Utils.SerializeToJson(teams, @".\Teams.json");
        }
    }
}
