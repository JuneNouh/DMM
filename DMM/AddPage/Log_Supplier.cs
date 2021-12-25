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
        TB_suppliers tbAdd;
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

        
        private void LoadDebitData()
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
    }
}