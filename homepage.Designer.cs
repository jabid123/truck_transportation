namespace truck_transportation
{
    partial class homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRegistertionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truckDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDatailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consigneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadingSheetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadingSheetToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.consignerToolStripMenuItem,
            this.consigneeToolStripMenuItem,
            this.productTypeToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.changePasswordToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRegistertionToolStripMenuItem,
            this.truckDetailsToolStripMenuItem,
            this.customerDatailToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // newRegistertionToolStripMenuItem
            // 
            this.newRegistertionToolStripMenuItem.Name = "newRegistertionToolStripMenuItem";
            this.newRegistertionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newRegistertionToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.newRegistertionToolStripMenuItem.Text = "New Registertion";
            this.newRegistertionToolStripMenuItem.Click += new System.EventHandler(this.newRegistertionToolStripMenuItem_Click);
            // 
            // truckDetailsToolStripMenuItem
            // 
            this.truckDetailsToolStripMenuItem.Name = "truckDetailsToolStripMenuItem";
            this.truckDetailsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.truckDetailsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.truckDetailsToolStripMenuItem.Text = "Truck Details";
            this.truckDetailsToolStripMenuItem.Click += new System.EventHandler(this.truckDetailsToolStripMenuItem_Click);
            // 
            // customerDatailToolStripMenuItem
            // 
            this.customerDatailToolStripMenuItem.Name = "customerDatailToolStripMenuItem";
            this.customerDatailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.customerDatailToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.customerDatailToolStripMenuItem.Text = "Customer datail";
            this.customerDatailToolStripMenuItem.Click += new System.EventHandler(this.customerDatailToolStripMenuItem_Click);
            // 
            // consignerToolStripMenuItem
            // 
            this.consignerToolStripMenuItem.Name = "consignerToolStripMenuItem";
            this.consignerToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.consignerToolStripMenuItem.Text = "Consigner";
            this.consignerToolStripMenuItem.Click += new System.EventHandler(this.consignerToolStripMenuItem_Click);
            // 
            // consigneeToolStripMenuItem
            // 
            this.consigneeToolStripMenuItem.Name = "consigneeToolStripMenuItem";
            this.consigneeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.consigneeToolStripMenuItem.Text = "Consignee";
            this.consigneeToolStripMenuItem.Click += new System.EventHandler(this.consigneeToolStripMenuItem_Click);
            // 
            // productTypeToolStripMenuItem
            // 
            this.productTypeToolStripMenuItem.Name = "productTypeToolStripMenuItem";
            this.productTypeToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.productTypeToolStripMenuItem.Text = "Product Type";
            this.productTypeToolStripMenuItem.Click += new System.EventHandler(this.productTypeToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadingSheetToolStripMenuItem1,
            this.loadingSheetToolStripMenuItem2,
            this.dispatchMemoToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // loadingSheetToolStripMenuItem1
            // 
            this.loadingSheetToolStripMenuItem1.Name = "loadingSheetToolStripMenuItem1";
            this.loadingSheetToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.loadingSheetToolStripMenuItem1.Text = "Consignment Note";
            this.loadingSheetToolStripMenuItem1.Click += new System.EventHandler(this.loadingSheetToolStripMenuItem1_Click);
            // 
            // loadingSheetToolStripMenuItem2
            // 
            this.loadingSheetToolStripMenuItem2.Name = "loadingSheetToolStripMenuItem2";
            this.loadingSheetToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
            this.loadingSheetToolStripMenuItem2.Text = "Loading Sheet";
            this.loadingSheetToolStripMenuItem2.Click += new System.EventHandler(this.loadingSheetToolStripMenuItem2_Click);
            // 
            // dispatchMemoToolStripMenuItem
            // 
            this.dispatchMemoToolStripMenuItem.Name = "dispatchMemoToolStripMenuItem";
            this.dispatchMemoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.dispatchMemoToolStripMenuItem.Text = "Dispatch Memo";
            this.dispatchMemoToolStripMenuItem.Click += new System.EventHandler(this.dispatchMemoToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(113, 20);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::truck_transportation.Properties.Resources.Mahindra_truck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRegistertionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truckDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDatailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consignerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consigneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadingSheetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadingSheetToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dispatchMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
    }
}



