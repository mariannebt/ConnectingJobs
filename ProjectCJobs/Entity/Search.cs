using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Search
    {
        #region Attributes

        private int idSearch;
        private string title;
        private string description;
        private string observation;
        private string wordKey;
        private DateTime startDate;
        private DateTime dueDate;
        private DateTime expirationDate;
        private User user;
        private Community community;
        private Job job;
        private Status status;
        private Tech technoloy;
        #endregion

        #region Constructor

        public Search()
        {

        }

        public Search(int idSearch, string title, string description, string observation, string wordKey, DateTime startDate, DateTime dueDate, DateTime expirationDate)
        {
            IdSearch = idSearch;
            Title = title;
            Description = description;
            Observation = observation;
            WordKey = wordKey;
            StartDate = startDate;
            DueDate = dueDate;
            ExpirationDate = expirationDate;
        }
        #endregion


        #region SetGet

        public int IdSearch
        {
            set { idSearch = value; }
            get { return idSearch; }
        }
        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public string Description
        {
            set { description = value; }
            get { return description; }
        }
        public string Observation
        {
            set { observation = value; }
            get { return observation; }
        }
        public string WordKey
        {
            set { wordKey = value; }
            get { return wordKey; }
        }
        public DateTime StartDate
        {
            set { startDate = value; }
            get { return startDate; }
        }
        public DateTime DueDate
        {
            set { dueDate = value; }
            get { return dueDate; }
        }
        public DateTime ExpirationDate
        {
            set { expirationDate = value; }
            get { return expirationDate; }
        }
        public User User
        {
            set { user = value; }
            get { return user; }
        }
        public Community Community
        {
            set { community = value; }
            get { return community; }
        }
        public Status Status
        {
            set { status = value; }
            get { return status; }
        }
        public Job Job
        {
            set { job = value; }
            get { return job; }
        }
        public Tech Technoloy
        {
            set { technoloy = value; }
            get { return technoloy; }
        }
        #endregion

        #region Overrise ToString
        public override string ToString()
        {
            return "Search: " + Title + Description + WordKey + Observation;
        }
        #endregion

    }
}
