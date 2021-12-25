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
        // databaseand tables
        DBDMMEntities db;
        TB_suppliers tbAdd;
        int id;
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
            add.btn_add.Text = "Add";
            add.btn_addclose.Text = "Add and close";
            add.page = this;
            add.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if(id > 0)
                {
                    db = new DBDMMEntities();
                    tbAdd = db.TB_suppliers.Where(x => x.ID == id).FirstOrDefault();
                    DMM.AddPage.Add_Supplier add = new AddPage.Add_Supplier();
                    add.id = id;
                    add.btn_add.Text = "Edit";
                    add.btn_addclose.Text = "Edit and close";
                    add.edt_name.Text = tbAdd.FullName;
                    add.edt_address.Text = tbAdd.Address;
                    add.edt_phone.Text = tbAdd.Phone;
                    add.page = this;
                    add.Show();
                }
                else
                {
                    MessageBox.Show("There no fiels to update");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Are you sure you want Delete the data","Delete operation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                    if (id > 0)
                    {
                        db = new DBDMMEntities();
                        tbAdd = db.TB_suppliers.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbAdd).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();
                        
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

        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db = new DBDMMEntities();
                    tbAdd = db.TB_suppliers.Where(x => x.ID == id).FirstOrDefault();
                    DMM.AddPage.Log_Supplier add = new AddPage.Log_Supplier();
                    add.txt_id.Text = id.ToString();
                    add.txt_name.Text = tbAdd.FullName.ToString();
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
    }
}
