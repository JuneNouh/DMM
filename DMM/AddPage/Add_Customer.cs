using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.AddPage
{
    public partial class Add_Customer : DevExpress.XtraEditors.XtraForm
    {
        // databaseand tables
        DBDMMEntities db;
        TB_suppliers tbAdd;
        public DMM.Pages.Page_Suppliers page;

        // other variable
        public int id;

        public Add_Customer()
        {
            InitializeComponent();
        }


        // add funmction
        private void Add()
        {
            // chceck empty fields
            if (edt_name.Text == "")
            {
                MessageBox.Show("Please Fill all fields", "Please Fill all fields",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                // Check if add or edit
                if(id==0)
                {
                    // Add
                    AddData();
                    ClearData();
                }
                else
                {
                    // Edit
                    EditData();
                }

                // Update Data
                page.LoadData();
            }
        }



        // Add Data
        private void AddData()
        {
            try
            {
                db = new DBDMMEntities();
                tbAdd = new TB_suppliers {

                    FullName = edt_name.Text,
                    Address = edt_address.Text,
                    Phone = edt_phone.Text,
                    DateT = DateTime.Now,
                    Debit = 0
                
                
                };

                db.Entry(tbAdd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("1ef882dc-2b02-4898-8238-d4cc9b99e224");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        // Edit Data
        private void EditData()
        {
            try
            {
                db = new DBDMMEntities();
                tbAdd = new TB_suppliers
                {
                    ID = id,
                    FullName = edt_name.Text,
                    Address = edt_address.Text,
                    Phone = edt_phone.Text,
                    DateT = DateTime.Now,
                   

                };

                db.Set<TB_suppliers>().AddOrUpdate(tbAdd);
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("c13206da-104a-4192-b211-f9a1c4842cef");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        // Add void
        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
           
        }
        // Add void and close
        private void btn_addclose_Click(object sender, EventArgs e)
        {
            Add();
            Close();
        }
        // Clear fields after add
        private void ClearData()
        {
            edt_address.Text = edt_name.Text = edt_phone.Text = "";
        }

        private void edt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void edt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only Number is allowed");
            }
        }
    }
}