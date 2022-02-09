using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMM.Pages;
using System.Threading.Tasks;

namespace DMM
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {
            InitializeComponent();
            LoadHomePage();
        }

        //void for load Home page
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadHomePage();
        }

        // Load Page
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try
            {
                pn_container.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                pn_container.Controls.Add(Page);
            }
            catch
            {

            }
        }

        private void LoadHomePage()
        {
            Page_Home page = new Page_Home();
            LoadPage(page);
        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            Page_Suppliers page = new Page_Suppliers();
            LoadPage(page);
        }

        private async void Main_Activated(object sender, EventArgs e)
        {
            BL.UPDATE uPDATE= new BL.UPDATE();

           await Task.Run(()=> uPDATE.SupplierDataUpdate());

        }
    }
}
