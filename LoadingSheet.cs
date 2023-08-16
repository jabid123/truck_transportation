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
    public partial class LoadingSheet : Form
    {
        public LoadingSheet()
        {
            InitializeComponent();
        }

        private void LoadingSheet_Load(object sender, EventArgs e)
        {
            string strcmd = "SELECT        CNS_Note.CNSID, CNS_Note.Dated, Consignee_DB.Consignee_Name, Consigner_DB.Con_Name,"+
                          " Product_DB.Product_Type, CNS_Note.No_Of_Packages, CNS_Note.Freight, CNS_Note.Worker, "+
                         " CNS_Note.Risk_Charges, CNS_Note.Other, CNS_Note.Sub_Total "+
                        " FROM            CNS_Note INNER JOIN "+
                        "                         Consignee_DB ON CNS_Note.Consignee_ID = Consignee_DB.Consignee_ID INNER JOIN "+
                        "                         Consigner_DB ON CNS_Note.Cons_ID = Consigner_DB.Con_ID INNER JOIN "+
                        "                         Product_DB ON CNS_Note.P_Type_ID = Product_DB.Product_ID "+
                        " WHERE        (CNS_Note.Status IS NULL) " +
                        " ORDER BY CNS_Note.Dated";
            DataTable dt = new DataTable();
            dt = SQLHelper.FillDt(strcmd);
            RptLoadingsheet obj = new RptLoadingsheet();
            obj.SetDataSource(dt);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.RefreshReport();
        }
    }
}
