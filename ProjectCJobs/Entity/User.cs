using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  
    public class User
    {
        #region Attributes
        private int idUser;
        private string name;
        private DateTime birthDate;
        private decimal yearsExperience;
        private string skill;
        private string description;

        #endregion

        #region Constructor
        protected User()
        {

        }

        protected User(int idUser, string name, DateTime birthDate, decimal yearsExperience, string skill, string description)
        {
            IdUser = idUser;
            Name = name;
            BirthDate = birthDate;
            YearsExperience = yearsExperience;
            Skill = skill;
            Description = description;
        }
        #endregion


        #region SetGet

        protected int IdUser
        {
            set { idUser = value; }
            get { return idUser; }
        }

        protected string Name
        {
            set { name = value; }
            get { return name; }
        }

        protected DateTime BirthDate
        {
            set { birthDate = value; }
            get { return birthDate; }
        }

        protected decimal YearsExperience
        {
            set { yearsExperience = value; }
            get { return yearsExperience; }
        }

        protected string Skill
        {
            set { skill = value; }
            get { return skill; }
        }

        protected string Description
        {
            set { description = value; }
            get { return description; }
        }
        #endregion

     
    }
}
