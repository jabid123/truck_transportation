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
    public partial class Consigner_Notes : Form
    {

        int sum = 0, freight = 0, other = 0, riskcharges = 0, worker = 0;

        public Consigner_Notes()
        {
            InitializeComponent();
        }

        private void Consigner_Notes_Load(object sender, EventArgs e)
        {
            //  Loadproducttype();
            string strcmd = "SELECT        Product_ID, Product_Type " +
            " FROM            Product_DB " +
            " ORDER BY Product_Type";
            DataTable dt = new DataTable();
            dt = SQLHelper.FillDt(strcmd);
            cmbProducttypeid.DisplayMember = "Product_Type";
            cmbProducttypeid.ValueMember = "Product_ID";
            cmbProducttypeid.DataSource = dt;
            LoadCOnsigner();
            LoadCOnsignee();


        }


        private void LoadCOnsigner()
        {
            string strcmd1 = "SELECT        Con_ID, Con_Name" +
                        " FROM            Consigner_DB" +
                        " ORDER BY Con_Name";
            DataTable dt1 = new DataTable();
            dt1 = SQLHelper.FillDt(strcmd1);
            cmbConr.DisplayMember = "Con_Name";
            cmbConr.ValueMember = "Con_ID";
            cmbConr.DataSource = dt1;


        }


        public void LoadCOnsignee()
        {


            string strcmd1 = "SELECT        Consignee_ID, Consignee_Name" +
                        " FROM            Consignee_DB" +
                        " ORDER BY Consignee_Name";
            DataTable dt1 = new DataTable();
            dt1 = SQLHelper.FillDt(strcmd1);
            cmbConsigneeID.DisplayMember = "Consignee_Name";
            cmbConsigneeID.ValueMember = "Consignee_ID";
            cmbConsigneeID.DataSource = dt1;


        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbConsigneeID.Text == "" || cmbConr.Text == "" || cmbConsigneeID.Text == "" || txtPackages.Text == "" || txtfreight.Text == "" || txtworker.Text == "" || txtriskcharges.Text == "" || txtOther.Text == "" || txtSubtotal.Text == "")
                {
                    MessageBox.Show("Enter Data", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    string strcmd = "INSERT INTO CNS_Note " +
                              " (Dated,Cons_ID,Consignee_ID,No_Of_Packages,P_Type_ID,Freight,Worker,Risk_Charges,Other,Sub_Total) " +
                              " VALUES('" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "'," + cmbConr.SelectedValue.ToString() + "," + cmbConsigneeID.SelectedValue.ToString() + "," + txtPackages.Text + "," + cmbProducttypeid.SelectedValue.ToString() + "," + txtfreight.Text + "," + txtworker.Text + "," + txtriskcharges.Text + "," + txtOther.Text + "," + txtSubtotal.Text + ")";

                    SQLHelper.ExecuteNonQuery(strcmd);

                    MessageBox.Show("Inserted Data Succesfully", "Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            LoadSubTotal();

        }
        private void LoadSubTotal()
        {
            sum = freight + riskcharges + worker + other;
            txtSubtotal.Text = sum.ToString();

        }

        private void txtworker_TextChanged(object sender, EventArgs e)
        {
            if (txtworker.Text != "")
            {
                worker = int.Parse(txtworker.Text);

                LoadSubTotal();
            }

        }

        private void txtriskcharges_TextChanged(object sender, EventArgs e)
        {
            if (txtriskcharges.Text != "")
            {
                riskcharges = int.Parse(txtriskcharges.Text);

                LoadSubTotal();
            }

        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {
            if (txtOther.Text != "")
            {
                other = int.Parse(txtOther.Text);

                LoadSubTotal();
            }

        }

        private void txtfreight_TextChanged_1(object sender, EventArgs e)
        {
            if (txtfreight.Text != "")
            {
                freight = int.Parse(txtfreight.Text);
                LoadSubTotal();
            }


        }


        private void txtPackages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ((char)Keys.Back))
            {
            }
            else
            {
                MessageBox.Show("Enter only number","Truck", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.KeyChar = ((char)Keys.Back);
            }
        }

        private void txtfreight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtworker_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtriskcharges_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOther_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Consigner_Notes_KeyPress(object sender, KeyPressEventArgs e)
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
