namespace College
{
    partial class mainForm
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
            this.btnLeads = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCourseRegistr = new System.Windows.Forms.Button();
            this.btnManagementLecturersAndCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeads
            // 
            this.btnLeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLeads.Location = new System.Drawing.Point(89, 543);
            this.btnLeads.Name = "btnLeads";
            this.btnLeads.Size = new System.Drawing.Size(400, 146);
            this.btnLeads.TabIndex = 0;
            this.btnLeads.Text = "מתענינים";
            this.btnLeads.UseVisualStyleBackColor = true;
            this.btnLeads.Click += new System.EventHandler(this.btnLeads_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(353, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "ברוכים הבאים למכללת חארטה";
            // 
            // btnCourseRegistr
            // 
            this.btnCourseRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCourseRegistr.Location = new System.Drawing.Point(537, 543);
            this.btnCourseRegistr.Name = "btnCourseRegistr";
            this.btnCourseRegistr.Size = new System.Drawing.Size(400, 146);
            this.btnCourseRegistr.TabIndex = 2;
            this.btnCourseRegistr.Text = "רישום לקורס";
            this.btnCourseRegistr.UseVisualStyleBackColor = true;
            this.btnCourseRegistr.Click += new System.EventHandler(this.btnCourseRegistr_Click);
            // 
            // btnManagementLecturersAndCourses
            // 
            this.btnManagementLecturersAndCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnManagementLecturersAndCourses.Location = new System.Drawing.Point(973, 543);
            this.btnManagementLecturersAndCourses.Name = "btnManagementLecturersAndCourses";
            this.btnManagementLecturersAndCourses.Size = new System.Drawing.Size(400, 146);
            this.btnManagementLecturersAndCourses.TabIndex = 3;
            this.btnManagementLecturersAndCourses.Text = "ניהול מרצים וקורסים";
            this.btnManagementLecturersAndCourses.UseVisualStyleBackColor = true;
            this.btnManagementLecturersAndCourses.Click += new System.EventHandler(this.btnManagementLecturersAndCourses_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 776);
            this.Controls.Add(this.btnManagementLecturersAndCourses);
            this.Controls.Add(this.btnCourseRegistr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeads);
            this.Name = "mainForm";
            this.Text = "college";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCourseRegistr;
        private System.Windows.Forms.Button btnManagementLecturersAndCourses;
    }
}

