using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Payment
    {

        #region Attributes

        private int idPayment;
        private double total;
        private string type;
        private Job job;
        private Invoice invoice;
        private Status status;
        #endregion

        #region Constructor

        public Payment()
        {

        }

        public Payment(int idPayment, double total, string type)
        {
            IdPayment = idPayment;
            Total = total;
            Type = type;
        }

        #endregion


        #region SetGet

        public int IdPayment
        {
            set { idPayment = value; }
            get { return idPayment;  }
        }
        public double Total
        {
            set { total = value; }
            get { return total; }
        }
        public string Type
        {
            set { type = value; }
            get { return type; }
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
        public Status Status
        {
            set { status = value; }
            get { return status; }
        }
        #endregion

        #region Overrise ToString

        public override string ToString()
        {
            return "Payment: " + total + type;
        }

        #endregion
    }
}
