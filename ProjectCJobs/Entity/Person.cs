using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Person : User
    {
        #region Attributes

        private string gender;
        private string maritalStatus;
        private string employmentStatus;
        #endregion

        #region Constructor

        public Person()
        {

        }

        public Person(string gender, string maritalStatus, string employmentStatus, string idUser)
        {
            Gender = gender;
            MaritalStatus = maritalStatus;
            EmploymentStatus = employmentStatus;

        }

        public Person(int idUser, string name, DateTime birthDate, decimal yearsExperience, string skill, string description, string gender, string maritalStatus, string employmentStatus, string idUser)
        {
            IdUser = idUser;
            Name = name;
            BirthDate = birthDate;
            YearsExperience = yearsExperience;
            Skill = skill;
            Description = description;
            Gender = gender;
            MaritalStatus = maritalStatus;
            EmploymentStatus = employmentStatus;

        }

        #endregion


        #region SetGet

        public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public string MaritalStatus
        {
            set { maritalStatus = value; }
            get { return maritalStatus; }
        }


        public string EmploymentStatus
        {
            set { employmentStatus = value; }
            get { return employmentStatus; }
        }

        #endregion

        #region Overrise ToString

        public override string ToString()
        {
            return "Id: " + IdUser + "Status: " + EmploymentStatus;
        }
        #endregion


    }
}
