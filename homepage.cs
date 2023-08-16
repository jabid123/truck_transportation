using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace truck_transportation
{
    public partial class homepage : Form
    {
        private int childFormNumber = 0;

        public homepage()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void newRegistertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newreg n = new newreg();
            n.Show();

        }

        private void truckDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Truck_datails t = new Truck_datails();
            t.Show();

        }


        private void customerDatailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cust_detail c = new cust_detail();
            c.Show();


        }

        private void consignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consigner c = new Consigner();
            c.Show();
        }


        private void consignerNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
        }

        private void consigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consignee c = new Consignee();
            c.Show();
        }

        private void loadingSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dispatchMemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispatch_Memo obj = new Dispatch_Memo();
            obj.MdiParent = this;
            obj.Show();
        }

        private void loadingSheetToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LoadingSheet obj = new LoadingSheet();
            obj.MdiParent = this;
            obj.Show();
        }

        private void loadingSheetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consigner_Notes c = new Consigner_Notes();
            c.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.MdiParent = this;
            r.Show();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Change_Pass c = new Change_Pass();

            c.Show();
        }

        




    }
}
