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
    public partial class Dispatch_Memo : Form
    {
        public Dispatch_Memo()
        {
            InitializeComponent();
        }

       
        private void Dispatch_Memo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'truckDBDataSet.Truckdb' table. You can move, or remove it, as needed.
            this.truckdbTableAdapter.Fill(this.truckDBDataSet.Truckdb);
         
           
        }
        private void LoadData()
        {
            string strcmd = "SELECT CNS_Note.CNSID, CNS_Note.Dated, Consigner_DB.Con_Name, Consignee_DB.Consignee_Name, Product_DB.Product_Type " +
                        " FROM   CNS_Note INNER JOIN " +
                        " Consignee_DB ON CNS_Note.Consignee_ID = Consignee_DB.Consignee_ID INNER JOIN " +
                        " Consigner_DB ON CNS_Note.Cons_ID = Consigner_DB.Con_ID INNER JOIN " +
                        " Product_DB ON CNS_Note.P_Type_ID = Product_DB.Product_ID " +
                        " WHERE (CNS_Note.Status IS NULL) " +
                        " ORDER BY CNS_Note.Dated";

            DataTable dt = new DataTable();
            dt = SQLHelper.FillDt(strcmd);
            dataGridView1.DataSource = dt;
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDispatched_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    string strID = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string strcmd = "UPDATE       CNS_Note "+
                                    " SET                Status ='Dispatched', DisDate ='"+ dateTimePicker1.Value.ToString("MM-dd-yyyy") +"', TruckID ="+ cmbtrucktype.SelectedValue +
                                    " WHERE        (CNSID ="+ strID +")";
                    SQLHelper.ExecuteNonQuery(strcmd);
                    counter++;
                }
            }
            if (counter == 0)
            {
                MessageBox.Show("Select any product from list");
            }
            else
            {
                MessageBox.Show("Product dispatched successfully");
                LoadData();
            }
        }
    }
}
