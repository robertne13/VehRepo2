namespace DBMigrateESFinal
{
    partial class Form1
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
            this.textDB = new System.Windows.Forms.TextBox();
            this.textPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelRead = new System.Windows.Forms.Label();
            this.labelWrite = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textIp = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCont = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CharLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CHText = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.STText = new System.Windows.Forms.Label();
            this.LblReemplazo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rpCont = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFuck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textDB
            // 
            this.textDB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textDB.Location = new System.Drawing.Point(77, 131);
            this.textDB.Name = "textDB";
            this.textDB.Size = new System.Drawing.Size(384, 20);
            this.textDB.TabIndex = 0;
            this.textDB.Text = "essentialmode";
            this.textDB.TextChanged += new System.EventHandler(this.TextDB_TextChanged);
            // 
            // textPW
            // 
            this.textPW.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textPW.Location = new System.Drawing.Point(77, 184);
            this.textPW.Name = "textPW";
            this.textPW.Size = new System.Drawing.Size(384, 20);
            this.textPW.TabIndex = 1;
            this.textPW.TextChanged += new System.EventHandler(this.TextPW_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(18, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(18, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(330, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Migrate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.BackColor = System.Drawing.Color.Transparent;
            this.labelRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRead.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelRead.Location = new System.Drawing.Point(17, 251);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(75, 24);
            this.labelRead.TabIndex = 5;
            this.labelRead.Text = "Read....";
            // 
            // labelWrite
            // 
            this.labelWrite.AutoSize = true;
            this.labelWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrite.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelWrite.Location = new System.Drawing.Point(16, 284);
            this.labelWrite.Name = "labelWrite";
            this.labelWrite.Size = new System.Drawing.Size(75, 24);
            this.labelWrite.TabIndex = 6;
            this.labelWrite.Text = "Read....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "IP:";
            // 
            // textIp
            // 
            this.textIp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textIp.Location = new System.Drawing.Point(77, 105);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(187, 20);
            this.textIp.TabIndex = 7;
            this.textIp.Text = "127.0.0.1";
            this.textIp.TextChanged += new System.EventHandler(this.TextIp_TextChanged);
            // 
            // textPort
            // 
            this.textPort.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textPort.Location = new System.Drawing.Point(384, 105);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(78, 20);
            this.textPort.TabIndex = 9;
            this.textPort.Text = "3306";
            this.textPort.TextChanged += new System.EventHandler(this.TextPort_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(349, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(18, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "User";
            // 
            // textUser
            // 
            this.textUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textUser.Location = new System.Drawing.Point(77, 157);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(384, 20);
            this.textUser.TabIndex = 11;
            this.textUser.Text = "root";
            this.textUser.TextChanged += new System.EventHandler(this.TextUser_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(196, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total:";
            // 
            // labelCont
            // 
            this.labelCont.AutoSize = true;
            this.labelCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCont.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCont.Location = new System.Drawing.Point(258, 424);
            this.labelCont.Name = "labelCont";
            this.labelCont.Size = new System.Drawing.Size(20, 24);
            this.labelCont.TabIndex = 14;
            this.labelCont.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(16, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Plate:";
            // 
            // labelPat
            // 
            this.labelPat.AutoSize = true;
            this.labelPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPat.Location = new System.Drawing.Point(100, 321);
            this.labelPat.Name = "labelPat";
            this.labelPat.Size = new System.Drawing.Size(84, 24);
            this.labelPat.TabIndex = 16;
            this.labelPat.Text = "AAA 000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(196, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Saved...";
            // 
            // CharLbl
            // 
            this.CharLbl.AutoSize = true;
            this.CharLbl.Cursor = System.Windows.Forms.Cursors.No;
            this.CharLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharLbl.ForeColor = System.Drawing.Color.Red;
            this.CharLbl.Location = new System.Drawing.Point(17, 216);
            this.CharLbl.Name = "CharLbl";
            this.CharLbl.Size = new System.Drawing.Size(75, 24);
            this.CharLbl.TabIndex = 18;
            this.CharLbl.Text = "Read....";
            this.CharLbl.Click += new System.EventHandler(this.CharLbl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(17, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Char Contados";
            // 
            // CHText
            // 
            this.CHText.AutoSize = true;
            this.CHText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHText.ForeColor = System.Drawing.Color.Lime;
            this.CHText.Location = new System.Drawing.Point(372, 470);
            this.CHText.Name = "CHText";
            this.CHText.Size = new System.Drawing.Size(90, 24);
            this.CHText.TabIndex = 20;
            this.CHText.Text = "SV Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(17, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Steam Contados";
            // 
            // STText
            // 
            this.STText.AutoSize = true;
            this.STText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STText.ForeColor = System.Drawing.Color.Lime;
            this.STText.Location = new System.Drawing.Point(372, 503);
            this.STText.Name = "STText";
            this.STText.Size = new System.Drawing.Size(90, 24);
            this.STText.TabIndex = 22;
            this.STText.Text = "SV Count";
            // 
            // LblReemplazo
            // 
            this.LblReemplazo.AutoSize = true;
            this.LblReemplazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReemplazo.ForeColor = System.Drawing.Color.Blue;
            this.LblReemplazo.Location = new System.Drawing.Point(15, 368);
            this.LblReemplazo.Name = "LblReemplazo";
            this.LblReemplazo.Size = new System.Drawing.Size(190, 31);
            this.LblReemplazo.TabIndex = 23;
            this.LblReemplazo.Text = "REEMPLAZO";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 71);
            this.button2.TabIndex = 24;
            this.button2.Text = "Repair Database";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // rpCont
            // 
            this.rpCont.AutoSize = true;
            this.rpCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpCont.ForeColor = System.Drawing.Color.Blue;
            this.rpCont.Location = new System.Drawing.Point(361, 12);
            this.rpCont.Name = "rpCont";
            this.rpCont.Size = new System.Drawing.Size(100, 31);
            this.rpCont.TabIndex = 25;
            this.rpCont.Text = "Repair";
            this.rpCont.Click += new System.EventHandler(this.RpCont_Click);
            // 
            // txtCount
            // 
            this.txtCount.Enabled = false;
            this.txtCount.Location = new System.Drawing.Point(376, 46);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(78, 20);
            this.txtCount.TabIndex = 26;
            this.txtCount.Text = "0";
            this.txtCount.TextChanged += new System.EventHandler(this.TxtCount_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBMigrateESFinal.Properties.Resources.hosting1;
            this.pictureBox1.Location = new System.Drawing.Point(171, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(406, 612);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "RGamez.net";
            // 
            // lblFuck
            // 
            this.lblFuck.AutoSize = true;
            this.lblFuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuck.ForeColor = System.Drawing.Color.Red;
            this.lblFuck.Location = new System.Drawing.Point(1, 34);
            this.lblFuck.Name = "lblFuck";
            this.lblFuck.Size = new System.Drawing.Size(369, 31);
            this.lblFuck.TabIndex = 29;
            this.lblFuck.Text = "REPAIR IS NOT ENABLED";
            this.lblFuck.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(473, 632);
            this.Controls.Add(this.lblFuck);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.rpCont);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblReemplazo);
            this.Controls.Add(this.STText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CHText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CharLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textIp);
            this.Controls.Add(this.labelWrite);
            this.Controls.Add(this.labelRead);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPW);
            this.Controls.Add(this.textDB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "DB Migrator Cars RGamez.net";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDB;
        private System.Windows.Forms.TextBox textPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.Label labelWrite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIp;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CharLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CHText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label STText;
        private System.Windows.Forms.Label LblReemplazo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label rpCont;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFuck;
    }
}

