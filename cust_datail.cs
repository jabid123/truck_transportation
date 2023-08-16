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
    public partial class cust_detail : Form
    {
        public cust_detail()
        {
            InitializeComponent();
        }


        public void disp()
        {
            SQLHelper.GetConnection();
            string strcmd = "select * from cust_DB";
            DataTable dt = new DataTable();
            dt = SQLHelper.FillDt(strcmd);
            dataGridView1.DataSource = dt;
            SQLHelper.ExecuteNonQuery(strcmd);

        }
        private void cust_detail_Load(object sender, EventArgs e)
        {
            disp();
        }
        private void clears()
        {
            txtname.Text = "";
            txtContactNo.Text = "";
            richTextBox1.Text = "";
            txtname.Focus();
        }




        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtContactNo.Text == "" || richTextBox1.Text == "")
                {
                    MessageBox.Show("Please enter all customer details", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    string st = "select * from cust_DB where Name = '" + txtname.Text + "'";

                    DataTable dt = SQLHelper.FillDt(st);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record alredy exist");
                    }
                    else
                    {

                        string strcmd = "INSERT INTO cust_DB " +
                                  " (Name,Contact_No,Address) " +
                                  " VALUES('" + txtname.Text + "'," + txtContactNo.Text + ",'" + richTextBox1.Text + "')";

                        SQLHelper.ExecuteNonQuery(strcmd);
                        disp();
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

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtContactNo.Text == "")
                {
                    MessageBox.Show("Please enter all customer details", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    string strcmd = "UPDATE       cust_DB  SET  Name = '" + txtname.Text + "' , Contact_No =" + txtContactNo.Text + " ,Address='" + richTextBox1.Text + "' where ID='" + txtID.Text + "'";
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
                if (txtID.Text == "")
                {
                    MessageBox.Show("Enter ID", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string strcmd = "Delete from cust_DB where ID='" + txtID.Text + "'";
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

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ((char)Keys.Back))
            {
            }
            else
            {
                MessageBox.Show("Enter only number", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.KeyChar = ((char)Keys.Back);
            }
        }

    }
}















