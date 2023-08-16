namespace truck_transportation
{
    partial class Dispatch_Memo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CNSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Con_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consignee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbtrucktype = new System.Windows.Forms.ComboBox();
            this.truckdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckDBDataSet = new truck_transportation.TruckDBDataSet();
            this.lbl_truck_type = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.truckdbTableAdapter = new truck_transportation.TruckDBDataSetTableAdapters.TruckdbTableAdapter();
            this.btnDispatched = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CNSID,
            this.Dated,
            this.Con_Name,
            this.Consignee_Name,
            this.Product_Type});
            this.dataGridView1.Location = new System.Drawing.Point(0, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FalseValue = "False";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "True";
            // 
            // CNSID
            // 
            this.CNSID.DataPropertyName = "CNSID";
            this.CNSID.HeaderText = "CNSID";
            this.CNSID.Name = "CNSID";
            // 
            // Dated
            // 
            this.Dated.DataPropertyName = "Dated";
            dataGridViewCellStyle1.Format = "dd-MM-yyyy";
            this.Dated.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dated.HeaderText = "Dated";
            this.Dated.Name = "Dated";
            // 
            // Con_Name
            // 
            this.Con_Name.DataPropertyName = "Con_Name";
            this.Con_Name.HeaderText = "Consignor";
            this.Con_Name.Name = "Con_Name";
            // 
            // Consignee_Name
            // 
            this.Consignee_Name.DataPropertyName = "Consignee_Name";
            this.Consignee_Name.HeaderText = "Consignee";
            this.Consignee_Name.Name = "Consignee_Name";
            // 
            // Product_Type
            // 
            this.Product_Type.DataPropertyName = "Product_Type";
            this.Product_Type.HeaderText = "Product";
            this.Product_Type.Name = "Product_Type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 75);
            this.panel2.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(255, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Truck Transportation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 71;
            this.label8.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 70;
            // 
            // cmbtrucktype
            // 
            this.cmbtrucktype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbtrucktype.DataSource = this.truckdbBindingSource;
            this.cmbtrucktype.DisplayMember = "Truck_Number";
            this.cmbtrucktype.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtrucktype.FormattingEnabled = true;
            this.cmbtrucktype.Location = new System.Drawing.Point(177, 128);
            this.cmbtrucktype.Name = "cmbtrucktype";
            this.cmbtrucktype.Size = new System.Drawing.Size(134, 24);
            this.cmbtrucktype.TabIndex = 73;
            this.cmbtrucktype.ValueMember = "Truck_ID";
            // 
            // truckdbBindingSource
            // 
            this.truckdbBindingSource.DataMember = "Truckdb";
            this.truckdbBindingSource.DataSource = this.truckDBDataSet;
            // 
            // truckDBDataSet
            // 
            this.truckDBDataSet.DataSetName = "TruckDBDataSet";
            this.truckDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_truck_type
            // 
            this.lbl_truck_type.AutoSize = true;
            this.lbl_truck_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_truck_type.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_truck_type.ForeColor = System.Drawing.Color.Black;
            this.lbl_truck_type.Location = new System.Drawing.Point(10, 131);
            this.lbl_truck_type.Name = "lbl_truck_type";
            this.lbl_truck_type.Size = new System.Drawing.Size(107, 18);
            this.lbl_truck_type.TabIndex = 72;
            this.lbl_truck_type.Text = "Truck Type";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_submit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(330, 120);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(110, 33);
            this.btn_submit.TabIndex = 87;
            this.btn_submit.Text = "Search";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // truckdbTableAdapter
            // 
            this.truckdbTableAdapter.ClearBeforeFill = true;
            // 
            // btnDispatched
            // 
            this.btnDispatched.BackColor = System.Drawing.Color.Fuchsia;
            this.btnDispatched.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatched.ForeColor = System.Drawing.Color.White;
            this.btnDispatched.Location = new System.Drawing.Point(359, 439);
            this.btnDispatched.Name = "btnDispatched";
            this.btnDispatched.Size = new System.Drawing.Size(122, 33);
            this.btnDispatched.TabIndex = 88;
            this.btnDispatched.Text = "Dispatched";
            this.btnDispatched.UseVisualStyleBackColor = false;
            this.btnDispatched.Click += new System.EventHandler(this.btnDispatched_Click);
            // 
            // Dispatch_Memo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(842, 479);
            this.Controls.Add(this.btnDispatched);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cmbtrucktype);
            this.Controls.Add(this.lbl_truck_type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dispatch_Memo";
            this.Text = "Dispatch_Memo";
            this.Load += new System.EventHandler(this.Dispatch_Memo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbtrucktype;
        private System.Windows.Forms.Label lbl_truck_type;
        private System.Windows.Forms.Button btn_submit;
        private TruckDBDataSet truckDBDataSet;
        private System.Windows.Forms.BindingSource truckdbBindingSource;
        private TruckDBDataSetTableAdapters.TruckdbTableAdapter truckdbTableAdapter;
        private System.Windows.Forms.Button btnDispatched;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Con_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consignee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Type;
    }
}