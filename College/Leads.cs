using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class Leads : Form
    {
        mainForm MainFormRefrens;
        public Leads(mainForm _mainFormRefrens)
        {
            InitializeComponent();
            MainFormRefrens = _mainFormRefrens;
            showAllLeads();
        }

        // add new leads
        private void btnAddLead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCellLead.Text) ||
                string.IsNullOrEmpty(txtCityLead.Text) ||
                string.IsNullOrEmpty(txtNameLead.Text))
            {
                MessageBox.Show("full all fild");
                return;
            }

            string query = @"INSERT INTO leads (leads_name, city, phone)
                             VALUES (@leads_name, @city, @phone)";
            if (MainFormRefrens.connectDb())
            {
                SqlCommand cmd = new SqlCommand(query, MainFormRefrens.connection);
                cmd.Parameters.AddWithValue("@leads_name", txtNameLead.Text);
                cmd.Parameters.AddWithValue("@city", txtCityLead.Text);
                cmd.Parameters.AddWithValue("@phone", txtCellLead.Text);
                
                int updateRows = cmd.ExecuteNonQuery();
                
                if (updateRows > 0)
                {
                    MessageBox.Show("נוסף בהצלחה");
                    showAllLeads();
                    MainFormRefrens.disConnectDb();
                    txtNameLead.Text = "";
                    txtCityLead.Text = "";
                    txtCellLead.Text = "";
                    return;
                }
            }
        }

        private void showAllLeads()
        {
            DataTable result = new DataTable();
            string qurey = @"SELECT * FROM leads";

            if (MainFormRefrens.connectDb())
            {
                SqlCommand cmd = new SqlCommand(qurey, MainFormRefrens.connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);
                MainFormRefrens.disConnectDb();
            }
            dgvAllLeads.DataSource = result;
        }
    }
}
