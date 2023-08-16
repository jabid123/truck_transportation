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
    public partial class Consignee : Form
    {
        public Consignee()
        {
            InitializeComponent();
        }

             public void Disp()
    {
       
            SQLHelper.GetConnection();
            string strcmd = "select * from Consignee_DB";
            DataTable dt = new DataTable();
            dt = SQLHelper.FillDt(strcmd);
            dataGridView1.DataSource = dt;
            SQLHelper.ExecuteNonQuery(strcmd);

    }
        private void clears()
        {
            txtConsignee_name.Text = "";
           ritConsignee_Adds.Text = "";
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConsignee_name.Text == "" ||  ritConsignee_Adds.Text == "")
                {
                    MessageBox.Show("Please enter all Consignee details", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    string st = "select * from Consignee_DB where Consignee_Name = '" + txtConsignee_name.Text + "'";

                    DataTable dt = SQLHelper.FillDt(st);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record alredy exist");
                    }
                    else
                    {

                        string strcmd = "INSERT INTO Consignee_DB " +
                                  " (Consignee_Name,Consignee_Addr) " +
                                  " VALUES('" + txtConsignee_name.Text + "','" + ritConsignee_Adds.Text + "')";

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


        
        private void button2_Click_1(object sender, EventArgs e)
        {
        
            try
            {
                if (txtConsignee_name.Text == "" || ritConsignee_Adds.Text == "")
                {
                    MessageBox.Show("Please enter all Consignee details", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    string strcmd = "UPDATE       Consignee_DB  SET  Consignee_Name = '" + txtConsignee_name.Text + "' ,Consignee_Addr='" + ritConsignee_Adds.Text + "' where Consignee_ID='" + txtID.Text + "'";
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

        private void button1_Click_1(object sender, EventArgs e)
  
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Enter ID", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string strcmd = "Delete from Consignee_DB where Consignee_ID=" + txtID.Text + " ";
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

        private void Consignee_Load(object sender, EventArgs e)
        {
            Disp();
        }

           

        

    
    }
}
