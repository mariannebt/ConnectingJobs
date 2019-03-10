using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Adress
    {
        #region Attributes

        private int idAdress;
        private string country;
        private string state;
        private string city;
        private string district;
        private string street;
        private int number;
        private string complement;
        private int postalCode;
        private User user;
        private Community community;

        #endregion

        #region Constructor

        public Adress()
        {

        }

        public Adress(int idAdress, string country, string state, string city, string district, string street, int number, string complement, int postalCode)
        {
            IdAdress    = idAdress;
            Country     = country;
            State       = state;
            City        = city;
            District    = district;
            Street      = street;
            Number      = number;
            Complement  = complement;
            PostalCode  = postalCode;

        }

        #endregion


        #region SetGet

        public int IdAdress
        {
            set { idAdress = value; }
            get { return idAdress;  }
        }
        public string Country
        {
            set { country = value; }
            get { return country;  }
        }
        public string State
        {
            set { state = value; }
            get { return state;  }
        }
        public string City
        {
            set { city = value; }
            get { return city;  }
        }
        public string District
        {
            set { district = value; }
            get { return district;  }
        }
        public string Street
        {
            set { street = value; }
            get { return street;  }
        }
        public int Number
        {
            set { number = value; }
            get { return number;  }
        }
        public string Complement
        {
            set { complement = value; }
            get { return complement;  }
        }
        public int PostalCode
        {
            set { postalCode = value; }
            get { return postalCode;  }
        }
        public User User
        {
            set { user = value; }
            get { return user;  }
        }
        public Community Community
        {
            set { community = value; }
            get { return community;  }
        }
        #endregion

        #region Overrise ToString
        public override string ToString()
        {
            return "Adress: " + Country + State + City + District + Street + Number + Complement + PostalCode;
        }
        #endregion

    }
}
