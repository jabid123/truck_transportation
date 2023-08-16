using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using truck_transportation.DataModel;


namespace truck_transportation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_log.Text.Trim() == "")
            {
                MessageBox.Show("Enter Username", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Enter Password", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string strcmd = "select * from loginDB where UserName='" + txt_log.Text + "'";
                DataTable dt = new DataTable();
                dt = DataModel.SQLHelper.FillDt(strcmd);

                string strPass = "";
                if (dt.Rows.Count > 0)
                {
                    strPass = dt.Rows[0]["Password"].ToString();
                }
                if (strPass == txt_password.Text)
                {
                    DataModel.Commons.uid = dt.Rows[0]["uid"].ToString();
                    DataModel.Commons.UserName = dt.Rows[0]["UserName"].ToString();
                }
                if (Commons.uid == "1")
                {

                    homepage o = new homepage();

                    this.Hide();
                    o.Show();

                }

                else
                {
                    MessageBox.Show("Invalid Password", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Focus();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("" + ex2);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}















