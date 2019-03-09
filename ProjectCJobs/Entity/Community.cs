using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Community
    {
        #region Attributes

        private int idCommunity;
        private int numberMembers;
        private string name;
        private string description;
        private string leader;

        #endregion

        #region Constructor

        public Community()
        {

        }

        public Community(int idCommunity, int numberMembers, string name, string description, string leader)                
        {
            IdCommunity   = idCommunity;
            NumberMembers = numberMembers;
            Name          = name;
            Description   = description;
            Leader        = leader;

    }

        #endregion


        #region SetGet

        public int IdCommunity
        {
            set { idCommunity = value; }
            get { return idCommunity;  }
        }
        public int NumberMembers
        {
            set { numberMembers = value; }
            get { return numberMembers;  }
        }
        public string Name
        {
            set { name = value; }
            get { return name;  }
        }
        public string Description
        {
            set { description = value; }
            get { return description;  }
        }
        public string Leader
        {
            set { leader = value; }
            get { return leader;  }
        }

        #endregion

        #region Overrise ToString

        public override string ToString()
        {
            return "Community: " + Name + NumberMembers + Leader ;
        }
        #endregion




    }
}
