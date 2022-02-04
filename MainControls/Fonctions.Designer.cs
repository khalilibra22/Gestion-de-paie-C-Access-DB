namespace Gestion_Paie_PFE.MainControls
{
    partial class Fonctions
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fonctions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchFon = new MetroFramework.Controls.MetroTextBox();
            this.ModifBtn = new System.Windows.Forms.Button();
            this.SuppBtn = new System.Windows.Forms.Button();
            this.TotFonc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NomFonc = new MetroFramework.Controls.MetroTextBox();
            this.AJOUTER = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescFnc = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.CancelModif = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchFon);
            this.panel1.Controls.Add(this.ModifBtn);
            this.panel1.Controls.Add(this.SuppBtn);
            this.panel1.Controls.Add(this.TotFonc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.metroGrid1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(465, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 580);
            this.panel1.TabIndex = 39;
            // 
            // SearchFon
            // 
            this.SearchFon.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.SearchFon.CustomButton.Image = null;
            this.SearchFon.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.SearchFon.CustomButton.Name = "";
            this.SearchFon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchFon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchFon.CustomButton.TabIndex = 1;
            this.SearchFon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchFon.CustomButton.UseSelectable = true;
            this.SearchFon.CustomButton.Visible = false;
            this.SearchFon.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SearchFon.Lines = new string[] {
        "Rechercher par nom de fonction"};
            this.SearchFon.Location = new System.Drawing.Point(173, 456);
            this.SearchFon.MaxLength = 32767;
            this.SearchFon.Name = "SearchFon";
            this.SearchFon.PasswordChar = '\0';
            this.SearchFon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchFon.SelectedText = "";
            this.SearchFon.SelectionLength = 0;
            this.SearchFon.SelectionStart = 0;
            this.SearchFon.ShortcutsEnabled = true;
            this.SearchFon.Size = new System.Drawing.Size(459, 23);
            this.SearchFon.TabIndex = 84;
            this.SearchFon.Text = "Rechercher par nom de fonction";
            this.SearchFon.UseSelectable = true;
            this.SearchFon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchFon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFon.TextChanged += new System.EventHandler(this.SearchFon_TextChanged);
            // 
            // ModifBtn
            // 
            this.ModifBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModifBtn.BackColor = System.Drawing.Color.White;
            this.ModifBtn.FlatAppearance.BorderSize = 0;
            this.ModifBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifBtn.Image = ((System.Drawing.Image)(resources.GetObject("ModifBtn.Image")));
            this.ModifBtn.Location = new System.Drawing.Point(92, 444);
            this.ModifBtn.Name = "ModifBtn";
            this.ModifBtn.Size = new System.Drawing.Size(54, 53);
            this.ModifBtn.TabIndex = 11;
            this.ModifBtn.UseVisualStyleBackColor = false;
            this.ModifBtn.Click += new System.EventHandler(this.ModifBtn_Click);
            // 
            // SuppBtn
            // 
            this.SuppBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SuppBtn.BackColor = System.Drawing.Color.White;
            this.SuppBtn.FlatAppearance.BorderSize = 0;
            this.SuppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppBtn.Image = ((System.Drawing.Image)(resources.GetObject("SuppBtn.Image")));
            this.SuppBtn.Location = new System.Drawing.Point(32, 447);
            this.SuppBtn.Name = "SuppBtn";
            this.SuppBtn.Size = new System.Drawing.Size(54, 53);
            this.SuppBtn.TabIndex = 9;
            this.SuppBtn.UseVisualStyleBackColor = false;
            this.SuppBtn.Click += new System.EventHandler(this.SuppBtn_Click);
            // 
            // TotFonc
            // 
            this.TotFonc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotFonc.AutoSize = true;
            this.TotFonc.BackColor = System.Drawing.Color.Transparent;
            this.TotFonc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotFonc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.TotFonc.Location = new System.Drawing.Point(245, 528);
            this.TotFonc.Name = "TotFonc";
            this.TotFonc.Size = new System.Drawing.Size(123, 23);
            this.TotFonc.TabIndex = 7;
            this.TotFonc.Text = "11 Fonctions";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(179, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "TOTAL:";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(10, 8);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(637, 423);
            this.metroGrid1.TabIndex = 5;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Nom de fonction";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Admin";
            this.Column4.Name = "Column4";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.panel6.Location = new System.Drawing.Point(6, 503);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(647, 7);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.panel5.Location = new System.Drawing.Point(5, 434);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(647, 7);
            this.panel5.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 573);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(643, 7);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(650, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 573);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(650, 7);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 580);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(10, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 10);
            this.panel4.TabIndex = 1;
            // 
            // NomFonc
            // 
            // 
            // 
            // 
            this.NomFonc.CustomButton.Image = null;
            this.NomFonc.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.NomFonc.CustomButton.Name = "";
            this.NomFonc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NomFonc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NomFonc.CustomButton.TabIndex = 1;
            this.NomFonc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NomFonc.CustomButton.UseSelectable = true;
            this.NomFonc.CustomButton.Visible = false;
            this.NomFonc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NomFonc.Lines = new string[0];
            this.NomFonc.Location = new System.Drawing.Point(11, 201);
            this.NomFonc.MaxLength = 32767;
            this.NomFonc.Name = "NomFonc";
            this.NomFonc.PasswordChar = '\0';
            this.NomFonc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NomFonc.SelectedText = "";
            this.NomFonc.SelectionLength = 0;
            this.NomFonc.SelectionStart = 0;
            this.NomFonc.ShortcutsEnabled = true;
            this.NomFonc.Size = new System.Drawing.Size(446, 23);
            this.NomFonc.TabIndex = 63;
            this.NomFonc.UseSelectable = true;
            this.NomFonc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NomFonc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AJOUTER
            // 
            this.AJOUTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.AJOUTER.FlatAppearance.BorderSize = 0;
            this.AJOUTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AJOUTER.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AJOUTER.ForeColor = System.Drawing.Color.White;
            this.AJOUTER.Image = ((System.Drawing.Image)(resources.GetObject("AJOUTER.Image")));
            this.AJOUTER.Location = new System.Drawing.Point(11, 297);
            this.AJOUTER.Name = "AJOUTER";
            this.AJOUTER.Size = new System.Drawing.Size(446, 47);
            this.AJOUTER.TabIndex = 62;
            this.AJOUTER.Text = "AJOUTER";
            this.AJOUTER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AJOUTER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AJOUTER.UseVisualStyleBackColor = false;
            this.AJOUTER.Click += new System.EventHandler(this.AJOUTER_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label8.Location = new System.Drawing.Point(7, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 19);
            this.label8.TabIndex = 61;
            this.label8.Text = "Nom de fonction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label3.Location = new System.Drawing.Point(165, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 37);
            this.label3.TabIndex = 60;
            this.label3.Text = "Fonctions";
            // 
            // DescFnc
            // 
            // 
            // 
            // 
            this.DescFnc.CustomButton.Image = null;
            this.DescFnc.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.DescFnc.CustomButton.Name = "";
            this.DescFnc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DescFnc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DescFnc.CustomButton.TabIndex = 1;
            this.DescFnc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DescFnc.CustomButton.UseSelectable = true;
            this.DescFnc.CustomButton.Visible = false;
            this.DescFnc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.DescFnc.Lines = new string[0];
            this.DescFnc.Location = new System.Drawing.Point(11, 256);
            this.DescFnc.MaxLength = 32767;
            this.DescFnc.Name = "DescFnc";
            this.DescFnc.PasswordChar = '\0';
            this.DescFnc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescFnc.SelectedText = "";
            this.DescFnc.SelectionLength = 0;
            this.DescFnc.SelectionStart = 0;
            this.DescFnc.ShortcutsEnabled = true;
            this.DescFnc.Size = new System.Drawing.Size(446, 23);
            this.DescFnc.TabIndex = 65;
            this.DescFnc.UseSelectable = true;
            this.DescFnc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescFnc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.label4.Location = new System.Drawing.Point(7, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 64;
            this.label4.Text = "Description";
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.ModifierBtn.FlatAppearance.BorderSize = 0;
            this.ModifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierBtn.ForeColor = System.Drawing.Color.White;
            this.ModifierBtn.Image = ((System.Drawing.Image)(resources.GetObject("ModifierBtn.Image")));
            this.ModifierBtn.Location = new System.Drawing.Point(11, 297);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(255, 47);
            this.ModifierBtn.TabIndex = 66;
            this.ModifierBtn.Text = "  MODIFIER";
            this.ModifierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModifierBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // CancelModif
            // 
            this.CancelModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.CancelModif.FlatAppearance.BorderSize = 0;
            this.CancelModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelModif.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelModif.ForeColor = System.Drawing.Color.White;
            this.CancelModif.Image = ((System.Drawing.Image)(resources.GetObject("CancelModif.Image")));
            this.CancelModif.Location = new System.Drawing.Point(272, 297);
            this.CancelModif.Name = "CancelModif";
            this.CancelModif.Size = new System.Drawing.Size(185, 47);
            this.CancelModif.TabIndex = 67;
            this.CancelModif.Text = "  ANNULER";
            this.CancelModif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelModif.UseVisualStyleBackColor = false;
            this.CancelModif.Click += new System.EventHandler(this.CancelModif_Click);
            // 
            // Fonctions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CancelModif);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.DescFnc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NomFonc);
            this.Controls.Add(this.AJOUTER);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Fonctions";
            this.Size = new System.Drawing.Size(1122, 580);
            this.Load += new System.EventHandler(this.Fonctions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ModifBtn;
        private System.Windows.Forms.Button SuppBtn;
        private System.Windows.Forms.Label TotFonc;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroTextBox SearchFon;
        private MetroFramework.Controls.MetroTextBox NomFonc;
        private System.Windows.Forms.Button AJOUTER;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox DescFnc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button CancelModif;
    }
}
