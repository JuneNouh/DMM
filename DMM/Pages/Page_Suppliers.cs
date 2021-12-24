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

namespace DMM.Pages
{
    public partial class Page_Suppliers : DevExpress.XtraEditors.XtraUserControl
    {
        public Page_Suppliers()
        {
            InitializeComponent();
           
            LoadData();
        }

        //Load data
        public void LoadData()
        {
            DMM.DBDMMEntities dbContext = new DMM.DBDMMEntities();
            dbContext.TB_suppliers.Load();
            gridControl1.DataSource = dbContext.TB_suppliers.Local.ToBindingList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DMM.AddPage.Add_Supplier add = new AddPage.Add_Supplier();
            add.id = 0;
            add.btn_add.Text = "Added";
            add.btn_addclose.Text = "added and close";
            add.page = this;
            add.Show();
        }
    }
}
