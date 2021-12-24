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

namespace DMM.AddPage
{
    public partial class Add_Supplier : DevExpress.XtraEditors.XtraForm
    {
        // databaseand tables
        DBDMMEntities db;
        TB_suppliers tbAdd;
        public DMM.Pages.Page_Suppliers page;

        // other variable
        public int id;

        public Add_Supplier()
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
                    Address  = edt_address.Text,
                    Phone    = edt_phone.Text,
                    DateT    = DateTime.Now,
                
                
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

        }



        // Add void
        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
            ClearData();
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

