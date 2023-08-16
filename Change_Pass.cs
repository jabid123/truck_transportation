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
    public partial class Change_Pass : Form
    {
        public Change_Pass()
        {
            InitializeComponent();
        }
         private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNew_Pass.Text == txtConfirm_Pass.Text)
                {
                    string strcmd = " UPDATE      loginDB " +
                            " SET   Password ='" + txtNew_Pass.Text + "' where (Password='" + txtcurr_Pass.Text + "')";
                    SQLHelper.ExecuteNonQuery(strcmd);
                    MessageBox.Show("Password Changed successfully", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
                else
                {
                    MessageBox.Show(" new Password and confirm Password Shoud be Same", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            }
           
        

    }
}
