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
    public partial class newreg : Form
    {
        public newreg()
        {
            InitializeComponent();
        }
         public void disp()
        {
            SQLHelper.GetConnection();
            string strcmd = "select * from SUP_DB";
            DataTable dt = new DataTable();
            dt = SQLHelper.FillDt(strcmd);
            dataGridView2.DataSource = dt;
            SQLHelper.ExecuteNonQuery(strcmd);

        }

        private void clears()
        {
            txtName.Text = "";
            txtContact_No.Text = "";
            rich_address.Text = "";
            txtEmail.Text = "";
            txtName.Focus();
        }
        private void newreg_Load(object sender, EventArgs e)
        {
            disp();
        }



        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContact_No.Text == "" || txtEmail.Text == "" || txtName.Text == "")
                {
                    MessageBox.Show("Enter Data", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    string st = "select * from SUP_DB where Name = '" + txtName.Text + "'";

                    DataTable dt = SQLHelper.FillDt(st);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Record alredy exist");
                    }
                    else
                    {

                        string gen;
                        if (rbmale.Checked)
                            gen = rbmale.Text;
                        else
                            gen = rbfemale.Text;




                        string strcmd = "INSERT INTO SUP_DB (Name,Contact_No,Address,Email_ID,Gender,DOB) VALUES('" + txtName.Text + "'," + txtContact_No.Text + ",'" + rich_address.Text + "','" + txtEmail.Text + "','" + gen + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "')";

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContact_No.Text == "" || txtEmail.Text == "" || txtName.Text == "")
                {
                    MessageBox.Show("Enter ID","Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string gen;

                    if (rbmale.Checked)
                        gen = rbmale.Text;
                    else
                        gen = rbfemale.Text;

                    string strcmd = "UPDATE       SUP_DB  SET  Name = '" + txtName.Text + "' , Contact_No =" + txtContact_No.Text + " ,Address='" + rich_address.Text + "',Email_ID='" + txtEmail.Text + "',Gender='" + gen + "',DOB='" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' where ID=" + txtID.Text + " ";
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
                if (txtID.Text.Trim()=="" )
                {
                    MessageBox.Show("Enter ID", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string strcmd = "Delete from SUP_DB where ID = '"+ txtID.Text +"' ";
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






