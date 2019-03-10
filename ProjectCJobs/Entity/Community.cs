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
        private Adress adress;
        private Contact contact;
        private List<UserCommunity> userCommunity;
        private Status status;
        private List<Search> search;
        private List<Tech> tech;
        private List<Offer> offer;
        private List<Job> job;
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
        public Adress Adress
        {
            set { adress = value; }
            get { return adress; }
        }
        public Contact Contact
        {
            set { contact = value; }
            get { return contact; }
        }
        public List<UserCommunity> UserCommunity
        {
            set { userCommunity = value; }
            get { return userCommunity; }
        }
        public Status Status
        {
            set { status = value; }
            get { return status; }
        }
        public List<Search> Search
        {
            set { search = value; }
            get { return search; }
        }
        public List<Tech> Tech
        {
            set { tech = value; }
            get { return tech; }
        }
        public List<Offer> Offer
        {
            set { offer = value; }
            get { return offer; }
        }
        public List<Job> Job
        {
            set { job = value; }
            get { return job; }
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
