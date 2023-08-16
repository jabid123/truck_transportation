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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductType.Text == "")
                {
                    MessageBox.Show("Enter Data", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    string strcmd = "INSERT INTO Product_DB (Product_Type) VALUES('" + cmbProductType.SelectedItem.ToString() + "')";

                    SQLHelper.ExecuteNonQuery(strcmd);


                    MessageBox.Show("Inserted Data Succesfully", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}