using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DMM.AddPage
{
    public partial class Log_Supplier : DevExpress.XtraEditors.XtraForm
    {
        // databaseand tables
        DBDMMEntities db;
        Debit_Suppliers tbAdd;
        int id;
        public Log_Supplier()
        {
            InitializeComponent();
           
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_id_Click(object sender, EventArgs e)
        {

        }

        
        public void LoadDebitData()
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text);
                db = new DBDMMEntities();
                gridControl1.DataSource = db.Debit_Suppliers.Where(x => x.ID_Supplier == id).ToList();
            }
            catch { }
            
        }


        private void LoadPaymentData()
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text);
                db = new DBDMMEntities();
                gridControl2.DataSource = db.PaymentSuppliers.Where(x => x.ID_Supplier == id).ToList();
            }
            catch { }

        }
       
        private void Log_Supplier_Load(object sender, EventArgs e)
        {
            LoadPaymentData();
            LoadDebitData();

        }

        private void btn_adddebit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txt_id.Text);
            var SupplierName = txt_name.Text;
            DMM.AddPage.Add_DebitSupplier add = new AddPage.Add_DebitSupplier();
            add.id = 0;
            add.btn_add.Text = "Add";
            add.btn_addclose.Text = "Add and close";
            add.page = this;
            add.SupplierID = id;
            add.SupplierName = SupplierName;
            add.Show();
        }

        private void btn_editdebit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db = new DBDMMEntities();
                    var supplierid = Convert.ToInt32(txt_id.Text);
                    var SupplierName = txt_name.Text;
                    DMM.AddPage.Add_DebitSupplier add = new AddPage.Add_DebitSupplier();
                    add.id = id;
                    add.btn_add.Text = "Edit";
                    add.btn_addclose.Text = "Edit and close";
                    add.page = this;
                    add.SupplierID = supplierid;
                    add.SupplierName = SupplierName;
                    add.edt_name.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("FullName"));
                    add.edt_debit.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Debit"));
                    add.Show();
                }
                else
                {
                    MessageBox.Show("There no fiels to update");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Are you sure you want Delete the data", "Delete operation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                    if (id > 0)
                    {
                        db = new DBDMMEntities();
                        tbAdd = db.Debit_Suppliers.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbAdd).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadDebitData();

                    }
                    else
                    {
                        MessageBox.Show("There no fiels to delete");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}