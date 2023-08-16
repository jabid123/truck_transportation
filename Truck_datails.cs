using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using truck_transportation.DataModel;
namespace truck_transportation
{
    public partial class Truck_datails : Form
    {
        public Truck_datails()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTruckID.Text == string.Empty)
            {
                errorProvider1.SetError(txtTruckID, "Enter Truck id");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtrucktype.Text == string.Empty)
            {
                errorProvider2.SetError(cmbtrucktype, "Enter Truck type");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        private void clears()
        {
            txttrucknumber.Text = "";
            txtdrivername.Text = "";
            cmbtrucktype.Text = "";
            txttrucknumber.Focus();
        }
        public void disp()
        {
            SQLHelper.GetConnection();
            string strcmd = "select * from Truckdb";
            DataTable dt = new DataTable();
            dt = SQLHelper.FillDt(strcmd);
            dataGridView1.DataSource = dt;
            SQLHelper.ExecuteNonQuery(strcmd);

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            try
            {
                if (txttrucknumber.Text=="" || txtdrivername.Text=="" || cmbtrucktype.Text=="" )

                {
                    MessageBox.Show("Enter all truck details", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                string strcmd = "INSERT INTO Truckdb (Truck_Number,Driver_Name,Truck_Type) VALUES('" + txttrucknumber.Text + "','" + txtdrivername.Text + "','" + cmbtrucktype.Text + "')";

                SQLHelper.ExecuteNonQuery(strcmd);

                disp();
                MessageBox.Show("Inserted Data Succesfully", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clears();

            }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Truck_datails_Load(object sender, EventArgs e)
        {
            disp();
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txttrucknumber.Text == "" || txtdrivername.Text == "" || cmbtrucktype.Text == "")
                {
                    MessageBox.Show("Enter all truck details", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    string strcmd = "UPDATE       Truckdb  SET Truck_Number   = '" + txttrucknumber.Text + "',Driver_Name='" + txtdrivername.Text + "', Truck_Type='" + cmbtrucktype.Text + "' where Truck_ID=" + txtTruckID.Text + " ";
                    SQLHelper.ExecuteNonQuery(strcmd);
                    disp();
                    MessageBox.Show(" Updated successfully", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clears();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTruckID.Text == "")
                {
                    MessageBox.Show("Please enter Truck ID", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string strcmd = "Delete from Truckdb where Truck_ID=" + txtTruckID.Text + " ";
                    SQLHelper.ExecuteNonQuery(strcmd);
                    disp();
                    MessageBox.Show("Data Deleted successfully", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clears();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


    }
}
