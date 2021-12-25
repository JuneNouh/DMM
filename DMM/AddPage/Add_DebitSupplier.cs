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
    public partial class Add_DebitSupplier : DevExpress.XtraEditors.XtraForm
    {
        // databaseand tables
        DBDMMEntities db;
        Debit_Suppliers tbAdd;
        public DMM.Pages.Page_Suppliers page;

        // other variable
        public int id;
        public int SupplierID;
        public string SupplierName;

        public Add_DebitSupplier()
        {
            InitializeComponent();
        }


        // add funmction
        private void Add()
        {
            // chceck empty fields
            if (edt_name.Text == "" ||edt_debit.Text=="" )
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
                tbAdd = new Debit_Suppliers {

                    FullName=edt_name.Text,
                    Debit=Convert.ToDouble(edt_debit),
                    SupplierName = SupplierName,
                    ID_Supplier = SupplierID,
                    DtaeT    = DateTime.Now,
                
                
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
                tbAdd = new Debit_Suppliers
                {
                    ID = id,
                    FullName = edt_name.Text,
                    Debit = Convert.ToDouble(edt_debit),
                    SupplierName = SupplierName,
                    ID_Supplier = SupplierID,
                    DtaeT = DateTime.Now,


                };

                db.Set<Debit_Suppliers>().AddOrUpdate(tbAdd);
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
            edt_name.Text = edt_debit.Text = "";
        }

        private void edt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void edt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}