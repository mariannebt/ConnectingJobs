using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Contact
    {
        #region Attributes

        private int idContact;
        private string nameContact;
        private string email;
        private string skype;
        #endregion

        #region Constructor

        public Contact()
        {

        }

        public Contact(int idContact, string nameContact, string email, string skype)
        {
            IdContact     = idContact;
            NameContact   = nameContact;
            Email         = email;
            Skype         = skype;
        }

        #endregion


        #region SetGet

        public int IdContact
        {
            set { idContact = value; }
            get { return idContact;  }
        }

        public string NameContact
        {
            set { nameContact = value; }
            get { return nameContact;  }
        }

        public string Email
        {
            set { email = value; }
            get { return email;  }
        }

        public string Skype
        {
            set { skype = value; }
            get { return skype;  }
        }


        #endregion


        #region Overrise ToString
        public override string ToString()
        {
            return "Name of the Contact: " + NameContact + ", email: " + email + ", Skype: " + skype;
        }
        #endregion
 
    }
}
