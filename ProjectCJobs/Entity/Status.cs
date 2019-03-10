using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Status
    {

        #region Attributes

        private int idStatus;
        private string name;
        private string observation;
        #endregion

        #region Constructor

        public Status()
        {

        }

        public Status(int idStatus, string name, string observation)
        {

        }

        #endregion


        #region SetGet

        public int IdStatus
        {
            set { idStatus = value; }
            get { return idStatus;  }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Observation
        {
            set { observation = value; }
            get { return observation; }
        }
        #endregion

        #region Overrise ToString

        public override string ToString()
        {
            return "Status: " + name;
        }
        #endregion

    }
}
