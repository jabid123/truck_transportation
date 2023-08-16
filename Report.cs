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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
           string strcmd=" SELECT CNS_Note.CNSID, CNS_Note.Dated, Consigner_DB.Con_Name AS COnsignor, Consignee_DB.Consignee_Name AS Consingee, CNS_Note.No_Of_Packages, Product_DB.Product_Type, "+
                         " Truckdb.Truck_Number "+
                         " FROM CNS_Note INNER JOIN "+
                         " Consigner_DB ON CNS_Note.Cons_ID = Consigner_DB.Con_ID INNER JOIN "+
                         " Consignee_DB ON CNS_Note.Consignee_ID = Consignee_DB.Consignee_ID INNER JOIN "+
                         " Product_DB ON CNS_Note.P_Type_ID = Product_DB.Product_ID INNER JOIN "+
                         " Truckdb ON CNS_Note.TruckID = Truckdb.Truck_ID "+
                         " WHERE        (CNS_Note.Status = 'Dispatched') AND (CNS_Note.Dated >='"+ DtFrom.Value.ToString("MM-dd-yyyy") +"' AND CNS_Note.Dated <='"+ DtTo.Value.ToString("MM-dd-yyyy") +"') "+
                         " ORDER BY CNS_Note.Dated";
           DataTable dt = new DataTable();
           dt = SQLHelper.FillDt(strcmd);
           dataGridView1.DataSource = dt;
                    }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
