namespace Gestion_Paie_PFE
{
    partial class MsBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsBox));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MsgTxt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AlertIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(413, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MsgTxt
            // 
            this.MsgTxt.AutoSize = true;
            this.MsgTxt.BackColor = System.Drawing.Color.Transparent;
            this.MsgTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgTxt.ForeColor = System.Drawing.Color.White;
            this.MsgTxt.Location = new System.Drawing.Point(80, 37);
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.Size = new System.Drawing.Size(77, 19);
            this.MsgTxt.TabIndex = 3;
            this.MsgTxt.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AlertIcon
            // 
            this.AlertIcon.Image = ((System.Drawing.Image)(resources.GetObject("AlertIcon.Image")));
            this.AlertIcon.Location = new System.Drawing.Point(14, 17);
            this.AlertIcon.Name = "AlertIcon";
            this.AlertIcon.Size = new System.Drawing.Size(60, 60);
            this.AlertIcon.TabIndex = 4;
            this.AlertIcon.TabStop = false;
            // 
            // MsBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(126)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(440, 100);
            this.Controls.Add(this.AlertIcon);
            this.Controls.Add(this.MsgTxt);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsBox";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EreurWind";
            this.Load += new System.EventHandler(this.EreurWind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label MsgTxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox AlertIcon;
    }
}