using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using truck_transportation.DataModel;
using System.Data.SqlClient;
namespace truck_transportation
{
    public partial class Consigner : Form
    {
        public Consigner()
        {
            InitializeComponent();
        }
        public void Disp()
        {

            SQLHelper.GetConnection();
            string strcmd = "select * from Consigner_DB";
            DataTable dt = new DataTable();
            dt = SQLHelper.FillDt(strcmd);
            dataGridView1.DataSource = dt;
            SQLHelper.ExecuteNonQuery(strcmd);

        }
        private void clears()
        {
            txtcon_name.Text = "";
            ritCon_Adds.Text = "";
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcon_name.Text == "" || ritCon_Adds.Text == "")
                {
                    MessageBox.Show("Please enter all Consigner details", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string st = "select * from Consigner_DB where Con_Name = '"+txtcon_name.Text+"'";

                    DataTable dt = SQLHelper.FillDt(st);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record alredy exist");
                    }
                    else
                    {
                        string strcmd = "INSERT INTO Consigner_DB " +
                                  " (Con_Name,Con_Address) " +
                                  " VALUES('" + txtcon_name.Text + "','" + ritCon_Adds.Text + "')";

                        SQLHelper.ExecuteNonQuery(strcmd);
                        Disp();
                        MessageBox.Show("Inserted Data Succesfully", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clears();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        private void Consigner_Load(object sender, EventArgs e)
        {
            Disp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcon_name.Text == "" || ritCon_Adds.Text == "")
                {
                    MessageBox.Show("Please enter all Consigner details", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    string strcmd = "UPDATE       Consigner_DB  SET  Con_Name = '" + txtcon_name.Text + "' ,Con_Address='" + ritCon_Adds.Text + "' where Con_ID='" + txtID.Text + "'";
                    SQLHelper.ExecuteNonQuery(strcmd);
                    Disp();
                    MessageBox.Show(" Updated successfully", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clears();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Enter ID", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string strcmd = "Delete from Consigner_DB where Con_ID=" + txtID.Text + " ";
                    SQLHelper.ExecuteNonQuery(strcmd);
                    Disp();
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


