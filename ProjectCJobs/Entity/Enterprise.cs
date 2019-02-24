using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Enterprise : User
    {
        #region Attributes
        private string business;
        private string size;

        #endregion

        #region Constructor
        public Enterprise()
        {

        }

        public Enterprise(string business, string size)
        {
            Business = business;
            Size = size;
        }

        public Enterprise(int idUser, string name, DateTime birthDate, decimal yearsExperience, string skill, string description, string business, string size)
        {
            IdUser = idUser;
            Name = name;
            BirthDate = birthDate;
            YearsExperience = yearsExperience;
            Skill = skill;
            Description = description;
            Business = business;
            Size = size;
        }

        #endregion

        #region SetGet

        public string Business
        {
            set { business = value; }
            get { return business; }
        }

        public string Size
        {
            set { size = value; }
            get { return size; }
        }

        #endregion

        #region Overrise ToString

        public override string ToString()
        {
            return "Id: " + IdUser + "Business: " + Business;
        }
        #endregion


    }
}
