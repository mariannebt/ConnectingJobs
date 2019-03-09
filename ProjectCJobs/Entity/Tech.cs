using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Tech
    {
        #region Attributes
        private int idTech;
        private string name;
        private string information;
        private string observation;
        #endregion

        #region Constructor

        public Tech()
        {

        }


        public Tech(int idTech, string name, string information, string observation)
        {
            IdTech      = idTech;
            Name        = name;
            Information = information;
            Observation = observation;
    }

        #endregion


        #region SetGet

        public int IdTech
        {
            set { idTech = value; }
            get { return idTech;  }
        }
        public string Name
        {
            set { name = value; }
            get { return name;  }
        }
        public string Information
        {
            set { information = value; }
            get { return information;  }
        }
        public string Observation
        {
            set { observation = value; }
            get { return observation;  }
        }
        #endregion

        #region Overrise ToString
        public override string ToString()
        {
            return "Technology: " + Name;
        }
        #endregion
        
    }
}
