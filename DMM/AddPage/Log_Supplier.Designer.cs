
namespace DMM.AddPage
{
    partial class Log_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_Supplier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_paymentprint = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_paymentedit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_paymentdelete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_paymentadd = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtaeT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_editdebit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_adddebit = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.simpleButton6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 772);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 117);
            this.panel1.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(80, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(20, 36);
            this.txt_id.TabIndex = 12;
            this.txt_id.Text = "0";
            this.txt_id.Click += new System.EventHandler(this.txt_id_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(595, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 117);
            this.label6.TabIndex = 11;
            this.label6.Text = "Remind: 5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SaddleBrown;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(398, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 117);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payed: 5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SlateGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(199, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 117);
            this.label4.TabIndex = 9;
            this.label4.Text = "Debit: 10";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_name.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(0, 0);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(199, 117);
            this.txt_name.TabIndex = 2;
            this.txt_name.Text = "Supplier Name";
            this.txt_name.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Appearance.Options.UseForeColor = true;
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton6.Location = new System.Drawing.Point(1222, 30);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(150, 62);
            this.simpleButton6.TabIndex = 8;
            this.simpleButton6.Text = "Clear";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 772);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gridControl2);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(653, 772);
            this.panel6.TabIndex = 3;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = typeof(DMM.PaymentSupplier);
            this.gridControl2.Location = new System.Drawing.Point(3, 69);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(647, 531);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPayment,
            this.colDateT});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colPayment
            // 
            this.colPayment.AppearanceCell.Options.UseTextOptions = true;
            this.colPayment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPayment.Caption = "Payed";
            this.colPayment.FieldName = "Payment";
            this.colPayment.MinWidth = 25;
            this.colPayment.Name = "colPayment";
            this.colPayment.OptionsColumn.AllowEdit = false;
            this.colPayment.Visible = true;
            this.colPayment.VisibleIndex = 0;
            this.colPayment.Width = 94;
            // 
            // colDateT
            // 
            this.colDateT.Caption = "payed date";
            this.colDateT.FieldName = "DateT";
            this.colDateT.MinWidth = 25;
            this.colDateT.Name = "colDateT";
            this.colDateT.OptionsColumn.AllowEdit = false;
            this.colDateT.Visible = true;
            this.colDateT.VisibleIndex = 1;
            this.colDateT.Width = 94;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel5.Controls.Add(this.btn_paymentprint);
            this.panel5.Controls.Add(this.simpleButton2);
            this.panel5.Controls.Add(this.btn_paymentedit);
            this.panel5.Controls.Add(this.btn_paymentdelete);
            this.panel5.Controls.Add(this.btn_paymentadd);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 669);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(653, 103);
            this.panel5.TabIndex = 2;
            // 
            // btn_paymentprint
            // 
            this.btn_paymentprint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_paymentprint.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paymentprint.Appearance.Options.UseFont = true;
            this.btn_paymentprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_paymentprint.ImageOptions.Image")));
            this.btn_paymentprint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_paymentprint.Location = new System.Drawing.Point(525, 32);
            this.btn_paymentprint.Name = "btn_paymentprint";
            this.btn_paymentprint.Size = new System.Drawing.Size(100, 50);
            this.btn_paymentprint.TabIndex = 4;
            this.btn_paymentprint.Text = "Print";
            this.btn_paymentprint.Click += new System.EventHandler(this.btn_paymentprint_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton2.Location = new System.Drawing.Point(406, 32);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(100, 50);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Update";
            // 
            // btn_paymentedit
            // 
            this.btn_paymentedit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_paymentedit.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paymentedit.Appearance.Options.UseFont = true;
            this.btn_paymentedit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_paymentedit.ImageOptions.Image")));
            this.btn_paymentedit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_paymentedit.Location = new System.Drawing.Point(288, 32);
            this.btn_paymentedit.Name = "btn_paymentedit";
            this.btn_paymentedit.Size = new System.Drawing.Size(100, 50);
            this.btn_paymentedit.TabIndex = 6;
            this.btn_paymentedit.Text = "Edit";
            this.btn_paymentedit.Click += new System.EventHandler(this.btn_paymentedit_Click);
            // 
            // btn_paymentdelete
            // 
            this.btn_paymentdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_paymentdelete.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paymentdelete.Appearance.Options.UseFont = true;
            this.btn_paymentdelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_paymentdelete.ImageOptions.Image")));
            this.btn_paymentdelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_paymentdelete.Location = new System.Drawing.Point(166, 31);
            this.btn_paymentdelete.Name = "btn_paymentdelete";
            this.btn_paymentdelete.Size = new System.Drawing.Size(100, 50);
            this.btn_paymentdelete.TabIndex = 7;
            this.btn_paymentdelete.Text = "Delete";
            this.btn_paymentdelete.Click += new System.EventHandler(this.btn_paymentdelete_Click);
            // 
            // btn_paymentadd
            // 
            this.btn_paymentadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_paymentadd.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paymentadd.Appearance.Options.UseFont = true;
            this.btn_paymentadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_paymentadd.ImageOptions.Image")));
            this.btn_paymentadd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_paymentadd.Location = new System.Drawing.Point(41, 30);
            this.btn_paymentadd.Name = "btn_paymentadd";
            this.btn_paymentadd.Size = new System.Drawing.Size(100, 50);
            this.btn_paymentadd.TabIndex = 8;
            this.btn_paymentadd.Text = "Add";
            this.btn_paymentadd.Click += new System.EventHandler(this.btn_paymentadd_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(653, 66);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(653, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 772);
            this.panel3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(DMM.Debit_Suppliers);
            this.gridControl1.Location = new System.Drawing.Point(0, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(741, 531);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName,
            this.colDebit,
            this.colDtaeT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Details";
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 25;
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            this.colFullName.Width = 94;
            // 
            // colDebit
            // 
            this.colDebit.AppearanceCell.Options.UseTextOptions = true;
            this.colDebit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDebit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDebit.Caption = "Debits";
            this.colDebit.FieldName = "Debit";
            this.colDebit.MinWidth = 25;
            this.colDebit.Name = "colDebit";
            this.colDebit.OptionsColumn.AllowEdit = false;
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 1;
            this.colDebit.Width = 94;
            // 
            // colDtaeT
            // 
            this.colDtaeT.Caption = "Date added";
            this.colDtaeT.FieldName = "DtaeT";
            this.colDtaeT.MinWidth = 25;
            this.colDtaeT.Name = "colDtaeT";
            this.colDtaeT.OptionsColumn.AllowEdit = false;
            this.colDtaeT.Visible = true;
            this.colDtaeT.VisibleIndex = 2;
            this.colDtaeT.Width = 94;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.Controls.Add(this.btn_print);
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Controls.Add(this.btn_editdebit);
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.btn_adddebit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 669);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(741, 103);
            this.panel4.TabIndex = 2;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_print.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_print.Location = new System.Drawing.Point(569, 32);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(100, 50);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "Print";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(450, 32);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 50);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_editdebit
            // 
            this.btn_editdebit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_editdebit.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editdebit.Appearance.Options.UseFont = true;
            this.btn_editdebit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_editdebit.ImageOptions.Image")));
            this.btn_editdebit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_editdebit.Location = new System.Drawing.Point(332, 32);
            this.btn_editdebit.Name = "btn_editdebit";
            this.btn_editdebit.Size = new System.Drawing.Size(100, 50);
            this.btn_editdebit.TabIndex = 6;
            this.btn_editdebit.Text = "Edit";
            this.btn_editdebit.Click += new System.EventHandler(this.btn_editdebit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(210, 31);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 50);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_adddebit
            // 
            this.btn_adddebit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_adddebit.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adddebit.Appearance.Options.UseFont = true;
            this.btn_adddebit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_adddebit.ImageOptions.Image")));
            this.btn_adddebit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_adddebit.Location = new System.Drawing.Point(85, 30);
            this.btn_adddebit.Name = "btn_adddebit";
            this.btn_adddebit.Size = new System.Drawing.Size(100, 50);
            this.btn_adddebit.TabIndex = 8;
            this.btn_adddebit.Text = "Add";
            this.btn_adddebit.Click += new System.EventHandler(this.btn_adddebit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Debits";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Log_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 889);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Log_Supplier";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Record";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Log_Supplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_editdebit;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_adddebit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btn_paymentprint;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_paymentedit;
        private DevExpress.XtraEditors.SimpleButton btn_paymentdelete;
        private DevExpress.XtraEditors.SimpleButton btn_paymentadd;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.Label txt_name;
        public System.Windows.Forms.Label txt_id;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colDtaeT;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colDateT;
    }
}