namespace College
{
    partial class ManagementLecturersAndCourses
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
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.dgvShowAllLecturers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLecturersName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLecturersHourlyRate = new System.Windows.Forms.TextBox();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDaysCourse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimeCourse = new System.Windows.Forms.TextBox();
            this.dtpOpenCourse = new System.Windows.Forms.DateTimePicker();
            this.ltsTopics = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPriceCourse = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTypeCourse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(92, 127);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 102;
            this.dgvCourses.RowTemplate.Height = 40;
            this.dgvCourses.Size = new System.Drawing.Size(470, 469);
            this.dgvCourses.TabIndex = 0;
            // 
            // dgvShowAllLecturers
            // 
            this.dgvShowAllLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAllLecturers.Location = new System.Drawing.Point(1087, 127);
            this.dgvShowAllLecturers.Name = "dgvShowAllLecturers";
            this.dgvShowAllLecturers.RowHeadersWidth = 102;
            this.dgvShowAllLecturers.RowTemplate.Height = 40;
            this.dgvShowAllLecturers.Size = new System.Drawing.Size(443, 469);
            this.dgvShowAllLecturers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(202, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "רשימת קורסים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1182, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "רשימת מרצים";
            // 
            // txtLecturersName
            // 
            this.txtLecturersName.Location = new System.Drawing.Point(1099, 713);
            this.txtLecturersName.Name = "txtLecturersName";
            this.txtLecturersName.Size = new System.Drawing.Size(285, 38);
            this.txtLecturersName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1438, 716);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "שם";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1438, 806);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "תעריף לשעה";
            // 
            // txtLecturersHourlyRate
            // 
            this.txtLecturersHourlyRate.Location = new System.Drawing.Point(1099, 803);
            this.txtLecturersHourlyRate.Name = "txtLecturersHourlyRate";
            this.txtLecturersHourlyRate.Size = new System.Drawing.Size(285, 38);
            this.txtLecturersHourlyRate.TabIndex = 6;
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.Location = new System.Drawing.Point(1190, 884);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(219, 58);
            this.btnAddLecturer.TabIndex = 8;
            this.btnAddLecturer.Text = "הוסף מרצה";
            this.btnAddLecturer.UseVisualStyleBackColor = true;
            this.btnAddLecturer.Click += new System.EventHandler(this.btnAddLecturer_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(176, 942);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(219, 58);
            this.btnAddCourse.TabIndex = 13;
            this.btnAddCourse.Text = "הוסף קורס";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "ימים";
            // 
            // txtDaysCourse
            // 
            this.txtDaysCourse.Location = new System.Drawing.Point(110, 695);
            this.txtDaysCourse.Name = "txtDaysCourse";
            this.txtDaysCourse.Size = new System.Drawing.Size(285, 38);
            this.txtDaysCourse.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 638);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "שעות";
            // 
            // txtTimeCourse
            // 
            this.txtTimeCourse.Location = new System.Drawing.Point(110, 635);
            this.txtTimeCourse.Name = "txtTimeCourse";
            this.txtTimeCourse.Size = new System.Drawing.Size(285, 38);
            this.txtTimeCourse.TabIndex = 9;
            // 
            // dtpOpenCourse
            // 
            this.dtpOpenCourse.Location = new System.Drawing.Point(110, 878);
            this.dtpOpenCourse.Name = "dtpOpenCourse";
            this.dtpOpenCourse.Size = new System.Drawing.Size(285, 38);
            this.dtpOpenCourse.TabIndex = 14;
            this.dtpOpenCourse.Value = new System.DateTime(2024, 7, 18, 12, 14, 35, 0);
            // 
            // ltsTopics
            // 
            this.ltsTopics.FormattingEnabled = true;
            this.ltsTopics.ItemHeight = 31;
            this.ltsTopics.Location = new System.Drawing.Point(697, 138);
            this.ltsTopics.Name = "ltsTopics";
            this.ltsTopics.Size = new System.Drawing.Size(248, 438);
            this.ltsTopics.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1182, 638);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 46);
            this.label7.TabIndex = 16;
            this.label7.Text = "הוספת מרצים";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(698, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 46);
            this.label8.TabIndex = 17;
            this.label8.Text = "רשימת נושאים";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 819);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 32);
            this.label9.TabIndex = 21;
            this.label9.Text = "מחיר";
            // 
            // txtPriceCourse
            // 
            this.txtPriceCourse.Location = new System.Drawing.Point(110, 816);
            this.txtPriceCourse.Name = "txtPriceCourse";
            this.txtPriceCourse.Size = new System.Drawing.Size(285, 38);
            this.txtPriceCourse.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 759);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "מקצוע";
            // 
            // txtTypeCourse
            // 
            this.txtTypeCourse.Location = new System.Drawing.Point(110, 756);
            this.txtTypeCourse.Name = "txtTypeCourse";
            this.txtTypeCourse.Size = new System.Drawing.Size(285, 38);
            this.txtTypeCourse.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 884);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 32);
            this.label11.TabIndex = 22;
            this.label11.Text = "תאריך פתיחה";
            // 
            // ManagementLecturersAndCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 1021);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPriceCourse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTypeCourse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ltsTopics);
            this.Controls.Add(this.dtpOpenCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDaysCourse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTimeCourse);
            this.Controls.Add(this.btnAddLecturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLecturersHourlyRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLecturersName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvShowAllLecturers);
            this.Controls.Add(this.dgvCourses);
            this.Name = "ManagementLecturersAndCourses";
            this.Text = "ManagementLecturersAndCourses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridView dgvShowAllLecturers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLecturersName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLecturersHourlyRate;
        private System.Windows.Forms.Button btnAddLecturer;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDaysCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimeCourse;
        private System.Windows.Forms.DateTimePicker dtpOpenCourse;
        private System.Windows.Forms.ListBox ltsTopics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPriceCourse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTypeCourse;
        private System.Windows.Forms.Label label11;
    }
}