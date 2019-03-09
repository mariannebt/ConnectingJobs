using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Telephone
    {
        #region Attributes

        private int idTelephone;
        private int countryCode;
        private int localCode;
        private int number;
        #endregion

        #region Constructor

        public Telephone()
        {

        }

        public Telephone(int idTelephone, int countryCode, int localCode, int number)
        {
            IdTelephone = idTelephone;
            CountryCode = countryCode;
            LocalCode   = localCode;
            Number      = number;
        }

        #endregion


        #region SetGet

        public int IdTelephone
        {
            set { idTelephone = value; }
            get { return idTelephone;  }
        }

        public int CountryCode
        {
            set { countryCode = value; }
            get { return countryCode;  }
        }

        public int LocalCode
        {
            set { localCode = value; }
            get { return localCode;  }
        }

        public int Number
        {
            set { number = value; }
            get { return number;  }
        }

        #endregion
        #region Overrise ToString
        public override string ToString()
        {
            return " Telephone number: +" + CountryCode + " " + LocalCode + " " + Number;
        }
        #endregion



    }
}
