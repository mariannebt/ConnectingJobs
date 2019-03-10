using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoice
    {

        #region Attributes

        private int idInvoice;
        private double price;
        private double tax;
        private double total;
        private Job job;
        private Payment payment;

        #endregion

        #region Constructor

        public Invoice()
        {

        }

        public Invoice(int idInvoice, double price, double tax, double total)
        {

            IdInvoice = idInvoice;
            Price     = price;
            Tax       = tax;
            Total     = total;
        }

        #endregion


        #region SetGet

        public int IdInvoice
        {
            set { idInvoice = value; }
            get { return idInvoice;  }
        }
        public double Price
        {
            set { price = value; }
            get { return price;  }
        }
        public double Tax
        {
            set { tax = value; }
            get { return tax;  }
        }
        public double Total
        {
            set { total = value; }
            get { return total;  }
        }
        public Job Job
        {
            set { job = value; }
            get { return job; }
        }
        public Payment Payment
        {
            set { payment = value; }
            get { return payment; }
        }

        #endregion

        #region Overrise ToString

        public override string ToString()
        {
            return "Invoice: " + idInvoice + total;
        }
        #endregion

    }
}
