using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMM.BL
{
    public class UPDATE
    {
        // Database and tables
        DBDMMEntities db;
        TB_suppliers tBSuppliers;
        PaymentSupplier tbpayment;
        Debit_Suppliers tbdebit;


        //
        int id;
        double Payment;
        double Debit;
        Double PaymentRs;


        public void SupplierDataUpdate()
        {
            try
            {
                db = new DBDMMEntities();
                var SupplierIDList = db.TB_suppliers.Select(x => x.ID).ToArray();
                for(int i=0; i< SupplierIDList.Length;i++)
                {
                    id = SupplierIDList[i];
                    // Get Debit
                    Debit = (Double)db.Debit_Suppliers.Where(x => x.ID_Supplier == id).Select(x => x.Debit).ToArray().Sum();
                    Payment = (Double)db.PaymentSuppliers.Where(x => x.ID_Supplier == id).Select(x => x.Payment).ToArray().Sum();
                    PaymentRs = Debit - Payment;
                    tBSuppliers = db.TB_suppliers.Where(x => x.ID == id).FirstOrDefault();
                    tBSuppliers.Debit = PaymentRs;
                    db.Entry(tBSuppliers).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges(); 
                    
                   





                } 
            }
            catch
            {

            }
        }

         
    }
}
