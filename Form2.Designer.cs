namespace Flynk
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Panel();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Marks = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnMrks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.error.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnMrks);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 553);
            this.panel1.TabIndex = 15;
            // 
            // txtRoll
            // 
            this.txtRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(6)))), ((int)(((byte)(49)))));
            this.txtRoll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoll.Font = new System.Drawing.Font("Paltime Solid", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoll.ForeColor = System.Drawing.Color.White;
            this.txtRoll.Location = new System.Drawing.Point(318, 94);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(326, 14);
            this.txtRoll.TabIndex = 16;
            this.txtRoll.Text = "Enter Roll Number";
            this.txtRoll.Click += new System.EventHandler(this.textBox1_Click);
            this.txtRoll.TextChanged += new System.EventHandler(this.txtRoll_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(318, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 1);
            this.panel2.TabIndex = 17;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.result.Controls.Add(this.error);
            this.result.Controls.Add(this.lblRemarks);
            this.result.Controls.Add(this.label1);
            this.result.Controls.Add(this.Remarks);
            this.result.Controls.Add(this.lblGrade);
            this.result.Controls.Add(this.label20);
            this.result.Controls.Add(this.Grade);
            this.result.Controls.Add(this.lblMarks);
            this.result.Controls.Add(this.label23);
            this.result.Controls.Add(this.Marks);
            this.result.Controls.Add(this.lblName);
            this.result.Controls.Add(this.label26);
            this.result.Controls.Add(this.lbl);
            this.result.Font = new System.Drawing.Font("Paltime Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Black;
            this.result.Location = new System.Drawing.Point(179, 199);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(542, 247);
            this.result.TabIndex = 25;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.lblGrade.Location = new System.Drawing.Point(212, 131);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(31, 33);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "B";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.label20.Location = new System.Drawing.Point(157, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 33);
            this.label20.TabIndex = 7;
            this.label20.Text = ":";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.Grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.Grade.Location = new System.Drawing.Point(52, 131);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(99, 33);
            this.Grade.TabIndex = 6;
            this.Grade.Text = "Grade";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.lblMarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.lblMarks.Location = new System.Drawing.Point(212, 84);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(101, 33);
            this.lblMarks.TabIndex = 5;
            this.lblMarks.Text = "77/100";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.label23.Location = new System.Drawing.Point(161, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 33);
            this.label23.TabIndex = 4;
            this.label23.Text = ":";
            // 
            // Marks
            // 
            this.Marks.AutoSize = true;
            this.Marks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.Marks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.Marks.Location = new System.Drawing.Point(52, 84);
            this.Marks.Name = "Marks";
            this.Marks.Size = new System.Drawing.Size(103, 33);
            this.Marks.TabIndex = 3;
            this.Marks.Text = "Marks";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.lblName.Location = new System.Drawing.Point(212, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(198, 33);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Peter Griffin";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.label26.Location = new System.Drawing.Point(144, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(21, 33);
            this.label26.TabIndex = 1;
            this.label26.Text = ":";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.lbl.Location = new System.Drawing.Point(52, 37);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(86, 33);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Name";
            // 
            // Remarks
            // 
            this.Remarks.AutoSize = true;
            this.Remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.Remarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.Remarks.Location = new System.Drawing.Point(31, 190);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(134, 33);
            this.Remarks.TabIndex = 9;
            this.Remarks.Text = "Remarks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(171, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = ":";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.lblRemarks.Location = new System.Drawing.Point(212, 190);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(153, 33);
            this.lblRemarks.TabIndex = 11;
            this.lblRemarks.Text = "Good Job!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Paltime Solid", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.button1.Image = global::Flynk.Properties.Resources.Search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(359, 135);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(173, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = global::Flynk.Properties.Resources.roll;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(278, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 31);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Paltime Solid", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnHelp.Image = global::Flynk.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 180);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(173, 58);
            this.btnHelp.TabIndex = 16;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnMrks
            // 
            this.btnMrks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.btnMrks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMrks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMrks.Font = new System.Drawing.Font("Paltime Solid", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMrks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnMrks.Image = global::Flynk.Properties.Resources.marks;
            this.btnMrks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMrks.Location = new System.Drawing.Point(0, 122);
            this.btnMrks.Name = "btnMrks";
            this.btnMrks.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMrks.Size = new System.Drawing.Size(173, 58);
            this.btnMrks.TabIndex = 15;
            this.btnMrks.Text = "Marks Lookup";
            this.btnMrks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMrks.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(4)))), ((int)(((byte)(34)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 122);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.BackgroundImage = global::Flynk.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(691, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 25);
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMin.BackgroundImage = global::Flynk.Properties.Resources.min;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Location = new System.Drawing.Point(661, 19);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 25);
            this.btnMin.TabIndex = 12;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox4.BackgroundImage = global::Flynk.Properties.Resources.Screenshot_2022_11_27_162402;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(169, 452);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(571, 101);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(41)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.label7.Location = new System.Drawing.Point(17, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(503, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "The input or roll number is wrong";
            // 
            // error
            // 
            this.error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(4)))), ((int)(((byte)(26)))));
            this.error.Controls.Add(this.label7);
            this.error.Font = new System.Drawing.Font("Paltime Solid", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Black;
            this.error.Location = new System.Drawing.Point(3, 3);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(542, 247);
            this.error.TabIndex = 26;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(6)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(729, 553);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.error.ResumeLayout(false);
            this.error.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMrks;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel result;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label Marks;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Remarks;
        private System.Windows.Forms.Panel error;
        private System.Windows.Forms.Label label7;
    }
}