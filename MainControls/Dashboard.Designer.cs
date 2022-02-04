namespace Gestion_Paie_PFE.MainControls
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradPanel6 = new GradientPanelDemo.GradPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DateP = new System.Windows.Forms.Label();
            this.TempsP = new System.Windows.Forms.Label();
            this.gradPanel5 = new GradientPanelDemo.GradPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.FonctTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gradPanel4 = new GradientPanelDemo.GradPanel();
            this.Histo = new System.Windows.Forms.Button();
            this.gradPanel3 = new GradientPanelDemo.GradPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.gradPanel2 = new GradientPanelDemo.GradPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.SalTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gradPanel1 = new GradientPanelDemo.GradPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.EmpTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gradPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gradPanel4.SuspendLayout();
            this.gradPanel3.SuspendLayout();
            this.gradPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gradPanel6
            // 
            this.gradPanel6.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.gradPanel6.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.gradPanel6.Controls.Add(this.pictureBox4);
            this.gradPanel6.Controls.Add(this.DateP);
            this.gradPanel6.Controls.Add(this.TempsP);
            this.gradPanel6.Location = new System.Drawing.Point(725, 381);
            this.gradPanel6.Name = "gradPanel6";
            this.gradPanel6.Size = new System.Drawing.Size(349, 159);
            this.gradPanel6.TabIndex = 5;
            this.gradPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.gradPanel6_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // DateP
            // 
            this.DateP.AutoSize = true;
            this.DateP.BackColor = System.Drawing.Color.Transparent;
            this.DateP.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateP.ForeColor = System.Drawing.Color.White;
            this.DateP.Location = new System.Drawing.Point(106, 22);
            this.DateP.Name = "DateP";
            this.DateP.Size = new System.Drawing.Size(138, 28);
            this.DateP.TabIndex = 4;
            this.DateP.Text = "05/06/2019";
            // 
            // TempsP
            // 
            this.TempsP.AutoSize = true;
            this.TempsP.BackColor = System.Drawing.Color.Transparent;
            this.TempsP.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempsP.ForeColor = System.Drawing.Color.White;
            this.TempsP.Location = new System.Drawing.Point(78, 66);
            this.TempsP.Name = "TempsP";
            this.TempsP.Size = new System.Drawing.Size(195, 77);
            this.TempsP.TabIndex = 3;
            this.TempsP.Text = "11:45";
            // 
            // gradPanel5
            // 
            this.gradPanel5.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.gradPanel5.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.gradPanel5.Controls.Add(this.button3);
            this.gradPanel5.Controls.Add(this.FonctTxt);
            this.gradPanel5.Controls.Add(this.label8);
            this.gradPanel5.Controls.Add(this.label9);
            this.gradPanel5.Controls.Add(this.pictureBox3);
            this.gradPanel5.Location = new System.Drawing.Point(725, 70);
            this.gradPanel5.Name = "gradPanel5";
            this.gradPanel5.Size = new System.Drawing.Size(349, 305);
            this.gradPanel5.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(16, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "Voir Plus ...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FonctTxt
            // 
            this.FonctTxt.AutoSize = true;
            this.FonctTxt.BackColor = System.Drawing.Color.Transparent;
            this.FonctTxt.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FonctTxt.ForeColor = System.Drawing.Color.White;
            this.FonctTxt.Location = new System.Drawing.Point(167, 131);
            this.FonctTxt.Name = "FonctTxt";
            this.FonctTxt.Size = new System.Drawing.Size(155, 112);
            this.FonctTxt.TabIndex = 6;
            this.FonctTxt.Text = "11";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tout les fonctions: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fonctions";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(125, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // gradPanel4
            // 
            this.gradPanel4.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.gradPanel4.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.gradPanel4.Controls.Add(this.Histo);
            this.gradPanel4.Location = new System.Drawing.Point(513, 333);
            this.gradPanel4.Name = "gradPanel4";
            this.gradPanel4.Size = new System.Drawing.Size(206, 207);
            this.gradPanel4.TabIndex = 3;
            // 
            // Histo
            // 
            this.Histo.BackColor = System.Drawing.Color.Transparent;
            this.Histo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Histo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Histo.FlatAppearance.BorderSize = 0;
            this.Histo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Histo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Histo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Histo.ForeColor = System.Drawing.Color.White;
            this.Histo.Image = ((System.Drawing.Image)(resources.GetObject("Histo.Image")));
            this.Histo.Location = new System.Drawing.Point(53, 52);
            this.Histo.Name = "Histo";
            this.Histo.Size = new System.Drawing.Size(100, 100);
            this.Histo.TabIndex = 6;
            this.Histo.UseVisualStyleBackColor = false;
            this.Histo.Click += new System.EventHandler(this.Histo_Click);
            // 
            // gradPanel3
            // 
            this.gradPanel3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.gradPanel3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.gradPanel3.Controls.Add(this.button4);
            this.gradPanel3.Location = new System.Drawing.Point(297, 333);
            this.gradPanel3.Name = "gradPanel3";
            this.gradPanel3.Size = new System.Drawing.Size(209, 207);
            this.gradPanel3.TabIndex = 2;
            this.gradPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.gradPanel3_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(57, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gradPanel2
            // 
            this.gradPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.gradPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.gradPanel2.Controls.Add(this.button2);
            this.gradPanel2.Controls.Add(this.SalTxt);
            this.gradPanel2.Controls.Add(this.label6);
            this.gradPanel2.Controls.Add(this.label4);
            this.gradPanel2.Controls.Add(this.pictureBox2);
            this.gradPanel2.Location = new System.Drawing.Point(297, 70);
            this.gradPanel2.Name = "gradPanel2";
            this.gradPanel2.Size = new System.Drawing.Size(422, 257);
            this.gradPanel2.TabIndex = 1;
            this.gradPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gradPanel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(17, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(389, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Voir Plus ...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SalTxt
            // 
            this.SalTxt.AutoSize = true;
            this.SalTxt.BackColor = System.Drawing.Color.Transparent;
            this.SalTxt.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalTxt.ForeColor = System.Drawing.Color.White;
            this.SalTxt.Location = new System.Drawing.Point(262, 78);
            this.SalTxt.Name = "SalTxt";
            this.SalTxt.Size = new System.Drawing.Size(155, 112);
            this.SalTxt.TabIndex = 5;
            this.SalTxt.Text = "31";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tout les salaires (ce mois): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Salaires";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(160, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gradPanel1
            // 
            this.gradPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.gradPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.gradPanel1.Controls.Add(this.button1);
            this.gradPanel1.Controls.Add(this.EmpTxt);
            this.gradPanel1.Controls.Add(this.label2);
            this.gradPanel1.Controls.Add(this.label1);
            this.gradPanel1.Controls.Add(this.pictureBox1);
            this.gradPanel1.Location = new System.Drawing.Point(52, 70);
            this.gradPanel1.Name = "gradPanel1";
            this.gradPanel1.Size = new System.Drawing.Size(239, 470);
            this.gradPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Voir Plus ...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpTxt
            // 
            this.EmpTxt.AutoSize = true;
            this.EmpTxt.BackColor = System.Drawing.Color.Transparent;
            this.EmpTxt.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTxt.ForeColor = System.Drawing.Color.White;
            this.EmpTxt.Location = new System.Drawing.Point(63, 251);
            this.EmpTxt.Name = "EmpTxt";
            this.EmpTxt.Size = new System.Drawing.Size(155, 112);
            this.EmpTxt.TabIndex = 3;
            this.EmpTxt.Text = "24";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tout les employés: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employés";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gradPanel6);
            this.Controls.Add(this.gradPanel5);
            this.Controls.Add(this.gradPanel4);
            this.Controls.Add(this.gradPanel3);
            this.Controls.Add(this.gradPanel2);
            this.Controls.Add(this.gradPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1125, 583);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.gradPanel6.ResumeLayout(false);
            this.gradPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gradPanel5.ResumeLayout(false);
            this.gradPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gradPanel4.ResumeLayout(false);
            this.gradPanel3.ResumeLayout(false);
            this.gradPanel2.ResumeLayout(false);
            this.gradPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradPanel1.ResumeLayout(false);
            this.gradPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanelDemo.GradPanel gradPanel1;
        private GradientPanelDemo.GradPanel gradPanel2;
        private GradientPanelDemo.GradPanel gradPanel3;
        private GradientPanelDemo.GradPanel gradPanel4;
        private GradientPanelDemo.GradPanel gradPanel5;
        private GradientPanelDemo.GradPanel gradPanel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EmpTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SalTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label FonctTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Histo;
        private System.Windows.Forms.Label DateP;
        private System.Windows.Forms.Label TempsP;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
    }
}
