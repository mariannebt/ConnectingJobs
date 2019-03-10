using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserCommunity
    {
        #region Attributes

        private int idCommunityUser;
        private Community community;
        private User user;
        #endregion

        #region Constructor

        public UserCommunity()
        {

        }

        public UserCommunity(int idCommunityUser)
        {
            IdCommunityUser = idCommunityUser;
        }

        #endregion


        #region SetGet

        public int IdCommunityUser
        {
            set { idCommunityUser = value; }
            get { return idCommunityUser; }
        }

        public Community Community
        {
            set { community = value; }
            get { return community; }
        }

        public User User
        {
            set { user = value; }
            get { return user; }
        }
        #endregion


        #region Overrise ToString
        public override string ToString()
        {
            return "UserCommunity: " + IdCommunityUser;
        }
        #endregion


    }
}
