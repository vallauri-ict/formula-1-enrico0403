namespace FormulaOneCrudFormProject
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTeam = new System.Windows.Forms.TabPage();
            this.cmbSecondDriver = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFirstDriver = new System.Windows.Forms.ComboBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTechnicalChief = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPowerUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nuovoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.apriToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stampaToolStripTeamButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tagliaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.incollaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPageDriver = new System.Windows.Forms.TabPage();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageTeam.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTeam);
            this.tabControlMain.Controls.Add(this.tabPageDriver);
            this.tabControlMain.Controls.Add(this.tabPageServices);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 561);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.cmbSecondDriver);
            this.tabPageTeam.Controls.Add(this.label7);
            this.tabPageTeam.Controls.Add(this.cmbFirstDriver);
            this.tabPageTeam.Controls.Add(this.cmbCountry);
            this.tabPageTeam.Controls.Add(this.label6);
            this.tabPageTeam.Controls.Add(this.txtChassis);
            this.tabPageTeam.Controls.Add(this.label5);
            this.tabPageTeam.Controls.Add(this.txtTechnicalChief);
            this.tabPageTeam.Controls.Add(this.label4);
            this.tabPageTeam.Controls.Add(this.txtPowerUnit);
            this.tabPageTeam.Controls.Add(this.label3);
            this.tabPageTeam.Controls.Add(this.label2);
            this.tabPageTeam.Controls.Add(this.txtFullTeamName);
            this.tabPageTeam.Controls.Add(this.label1);
            this.tabPageTeam.Controls.Add(this.listBoxTeam);
            this.tabPageTeam.Controls.Add(this.toolStrip1);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeam.Size = new System.Drawing.Size(776, 535);
            this.tabPageTeam.TabIndex = 0;
            this.tabPageTeam.Text = "TEAM";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // cmbSecondDriver
            // 
            this.cmbSecondDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondDriver.FormattingEnabled = true;
            this.cmbSecondDriver.Location = new System.Drawing.Point(222, 239);
            this.cmbSecondDriver.Name = "cmbSecondDriver";
            this.cmbSecondDriver.Size = new System.Drawing.Size(178, 21);
            this.cmbSecondDriver.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Second Driver:";
            // 
            // cmbFirstDriver
            // 
            this.cmbFirstDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirstDriver.FormattingEnabled = true;
            this.cmbFirstDriver.Location = new System.Drawing.Point(222, 199);
            this.cmbFirstDriver.Name = "cmbFirstDriver";
            this.cmbFirstDriver.Size = new System.Drawing.Size(178, 21);
            this.cmbFirstDriver.TabIndex = 14;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(222, 64);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(178, 21);
            this.cmbCountry.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "First Driver:";
            // 
            // txtChassis
            // 
            this.txtChassis.Location = new System.Drawing.Point(222, 161);
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(178, 20);
            this.txtChassis.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chassis:";
            // 
            // txtTechnicalChief
            // 
            this.txtTechnicalChief.Location = new System.Drawing.Point(222, 128);
            this.txtTechnicalChief.Name = "txtTechnicalChief";
            this.txtTechnicalChief.Size = new System.Drawing.Size(178, 20);
            this.txtTechnicalChief.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Technical Chief:";
            // 
            // txtPowerUnit
            // 
            this.txtPowerUnit.Location = new System.Drawing.Point(222, 95);
            this.txtPowerUnit.Name = "txtPowerUnit";
            this.txtPowerUnit.Size = new System.Drawing.Size(178, 20);
            this.txtPowerUnit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Power Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country:";
            // 
            // txtFullTeamName
            // 
            this.txtFullTeamName.Location = new System.Drawing.Point(222, 35);
            this.txtFullTeamName.Name = "txtFullTeamName";
            this.txtFullTeamName.Size = new System.Drawing.Size(178, 20);
            this.txtFullTeamName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Team Name:";
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.Location = new System.Drawing.Point(3, 28);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(120, 504);
            this.listBoxTeam.TabIndex = 1;
            this.listBoxTeam.SelectedValueChanged += new System.EventHandler(this.listBoxTeam_SelectedValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripButton,
            this.apriToolStripButton,
            this.salvaToolStripButton,
            this.stampaToolStripTeamButton,
            this.toolStripSeparator,
            this.tagliaToolStripButton,
            this.copiaToolStripButton,
            this.incollaToolStripButton,
            this.toolStripSeparator1,
            this.ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nuovoToolStripButton
            // 
            this.nuovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuovoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuovoToolStripButton.Image")));
            this.nuovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuovoToolStripButton.Name = "nuovoToolStripButton";
            this.nuovoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nuovoToolStripButton.Text = "&Nuovo";
            // 
            // apriToolStripButton
            // 
            this.apriToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.apriToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("apriToolStripButton.Image")));
            this.apriToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.apriToolStripButton.Name = "apriToolStripButton";
            this.apriToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.apriToolStripButton.Text = "&Apri";
            // 
            // salvaToolStripButton
            // 
            this.salvaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvaToolStripButton.Image")));
            this.salvaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvaToolStripButton.Name = "salvaToolStripButton";
            this.salvaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvaToolStripButton.Text = "&Salva";
            // 
            // stampaToolStripTeamButton
            // 
            this.stampaToolStripTeamButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stampaToolStripTeamButton.Image = ((System.Drawing.Image)(resources.GetObject("stampaToolStripTeamButton.Image")));
            this.stampaToolStripTeamButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stampaToolStripTeamButton.Name = "stampaToolStripTeamButton";
            this.stampaToolStripTeamButton.Size = new System.Drawing.Size(23, 22);
            this.stampaToolStripTeamButton.Text = "&Stampa";
            this.stampaToolStripTeamButton.Click += new System.EventHandler(this.stampaToolStripTeamButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tagliaToolStripButton
            // 
            this.tagliaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tagliaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tagliaToolStripButton.Image")));
            this.tagliaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagliaToolStripButton.Name = "tagliaToolStripButton";
            this.tagliaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.tagliaToolStripButton.Text = "&Taglia";
            // 
            // copiaToolStripButton
            // 
            this.copiaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiaToolStripButton.Image")));
            this.copiaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiaToolStripButton.Name = "copiaToolStripButton";
            this.copiaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiaToolStripButton.Text = "&Copia";
            // 
            // incollaToolStripButton
            // 
            this.incollaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incollaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("incollaToolStripButton.Image")));
            this.incollaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incollaToolStripButton.Name = "incollaToolStripButton";
            this.incollaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.incollaToolStripButton.Text = "&Incolla";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton.Image")));
            this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton.Text = "&?";
            // 
            // tabPageDriver
            // 
            this.tabPageDriver.Location = new System.Drawing.Point(4, 22);
            this.tabPageDriver.Name = "tabPageDriver";
            this.tabPageDriver.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDriver.Size = new System.Drawing.Size(776, 535);
            this.tabPageDriver.TabIndex = 1;
            this.tabPageDriver.Text = "DRIVER";
            this.tabPageDriver.UseVisualStyleBackColor = true;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(776, 535);
            this.tabPageServices.TabIndex = 2;
            this.tabPageServices.Text = "-- Services --";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Formula One CRUD";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageTeam.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nuovoToolStripButton;
        private System.Windows.Forms.ToolStripButton apriToolStripButton;
        private System.Windows.Forms.ToolStripButton salvaToolStripButton;
        private System.Windows.Forms.ToolStripButton stampaToolStripTeamButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tagliaToolStripButton;
        private System.Windows.Forms.ToolStripButton copiaToolStripButton;
        private System.Windows.Forms.ToolStripButton incollaToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButton;
        private System.Windows.Forms.TabPage tabPageDriver;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTechnicalChief;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPowerUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSecondDriver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFirstDriver;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label6;
    }
}

