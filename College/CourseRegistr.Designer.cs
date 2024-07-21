namespace College
{
    partial class CourseRegistr
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ltsStudent = new System.Windows.Forms.ListBox();
            this.ltsCourses = new System.Windows.Forms.ListBox();
            this.lblCourceName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPaymed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(409, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "הרשמה לקורסים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(423, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "הוספת קורס לתלמיד";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ltsStudent
            // 
            this.ltsStudent.FormattingEnabled = true;
            this.ltsStudent.ItemHeight = 31;
            this.ltsStudent.Location = new System.Drawing.Point(818, 179);
            this.ltsStudent.Name = "ltsStudent";
            this.ltsStudent.Size = new System.Drawing.Size(271, 562);
            this.ltsStudent.TabIndex = 2;
            this.ltsStudent.SelectedIndexChanged += new System.EventHandler(this.ltsStudent_SelectedIndexChanged);
            // 
            // ltsCourses
            // 
            this.ltsCourses.FormattingEnabled = true;
            this.ltsCourses.ItemHeight = 31;
            this.ltsCourses.Location = new System.Drawing.Point(95, 179);
            this.ltsCourses.Name = "ltsCourses";
            this.ltsCourses.Size = new System.Drawing.Size(255, 562);
            this.ltsCourses.TabIndex = 3;
            this.ltsCourses.SelectedIndexChanged += new System.EventHandler(this.ltsCourses_SelectedIndexChanged);
            // 
            // lblCourceName
            // 
            this.lblCourceName.AutoSize = true;
            this.lblCourceName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCourceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCourceName.Location = new System.Drawing.Point(478, 386);
            this.lblCourceName.Name = "lblCourceName";
            this.lblCourceName.Size = new System.Drawing.Size(225, 46);
            this.lblCourceName.TabIndex = 5;
            this.lblCourceName.Text = "בחר שם קורס";
            this.lblCourceName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(890, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "סטונדטים";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "קורסים";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStudentName.Location = new System.Drawing.Point(458, 299);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(263, 46);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "בחר שם סטודנט";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "הוספה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(485, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "יתרת תשלום";
            // 
            // lblPaymed
            // 
            this.lblPaymed.AutoSize = true;
            this.lblPaymed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPaymed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPaymed.Location = new System.Drawing.Point(337, 782);
            this.lblPaymed.Name = "lblPaymed";
            this.lblPaymed.Size = new System.Drawing.Size(488, 42);
            this.lblPaymed.TabIndex = 12;
            this.lblPaymed.Text = "בחר תלמיד להצגת יתרת תשלום";
            // 
            // CourseRegistr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 881);
            this.Controls.Add(this.lblPaymed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCourceName);
            this.Controls.Add(this.ltsCourses);
            this.Controls.Add(this.ltsStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CourseRegistr";
            this.Text = "CourseRegistr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltsStudent;
        private System.Windows.Forms.ListBox ltsCourses;
        private System.Windows.Forms.Label lblCourceName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPaymed;
    }
}