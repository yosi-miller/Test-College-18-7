namespace College
{
    partial class Leads
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
            this.txtNameLead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCityLead = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCellLead = new System.Windows.Forms.TextBox();
            this.btnAddLead = new System.Windows.Forms.Button();
            this.dgvAllLeads = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLeads)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(214, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "רשימת מתענינים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(817, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "הוספת מתעניין";
            // 
            // txtNameLead
            // 
            this.txtNameLead.Location = new System.Drawing.Point(825, 294);
            this.txtNameLead.Name = "txtNameLead";
            this.txtNameLead.Size = new System.Drawing.Size(200, 38);
            this.txtNameLead.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1058, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1058, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "עיר";
            // 
            // txtCityLead
            // 
            this.txtCityLead.Location = new System.Drawing.Point(825, 387);
            this.txtCityLead.Name = "txtCityLead";
            this.txtCityLead.Size = new System.Drawing.Size(200, 38);
            this.txtCityLead.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1058, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "טלפון";
            // 
            // txtCellLead
            // 
            this.txtCellLead.Location = new System.Drawing.Point(825, 488);
            this.txtCellLead.Name = "txtCellLead";
            this.txtCellLead.Size = new System.Drawing.Size(200, 38);
            this.txtCellLead.TabIndex = 6;
            // 
            // btnAddLead
            // 
            this.btnAddLead.Location = new System.Drawing.Point(872, 619);
            this.btnAddLead.Name = "btnAddLead";
            this.btnAddLead.Size = new System.Drawing.Size(153, 74);
            this.btnAddLead.TabIndex = 8;
            this.btnAddLead.Text = "הוספה";
            this.btnAddLead.UseVisualStyleBackColor = true;
            this.btnAddLead.Click += new System.EventHandler(this.btnAddLead_Click);
            // 
            // dgvAllLeads
            // 
            this.dgvAllLeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllLeads.Location = new System.Drawing.Point(75, 218);
            this.dgvAllLeads.Name = "dgvAllLeads";
            this.dgvAllLeads.RowHeadersWidth = 102;
            this.dgvAllLeads.RowTemplate.Height = 40;
            this.dgvAllLeads.Size = new System.Drawing.Size(546, 475);
            this.dgvAllLeads.TabIndex = 10;
            // 
            // Leads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 856);
            this.Controls.Add(this.dgvAllLeads);
            this.Controls.Add(this.btnAddLead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCellLead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCityLead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameLead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Leads";
            this.Text = "Leads";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLeads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameLead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCityLead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCellLead;
        private System.Windows.Forms.Button btnAddLead;
        private System.Windows.Forms.DataGridView dgvAllLeads;
    }
}