using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Job
    {
        #region Attributes

        private int idJob;
        private string title;
        private string remote;
        private string observation;
        private DateTime startDate;
        private DateTime dueDate;
        private DateTime finishDate;
        private User user;
        private Community community;
        private Search search;
        private Offer offer;
        private Status status;
        private Tech technoloy;
        private Invoice invoice;
        private Payment payment;
        #endregion

        #region Constructor

        public Job()
        {

        }

        public Job(int idJob, string title, string remote, string observation, DateTime startDate, DateTime dueDate, DateTime finishDate)
        {
            IdJob       = idJob;
            Title       = title;
            Remote      = remote;
            Observation = observation;
            StartDate   = startDate;
            DueDate     = dueDate;
            FinishDate  = finishDate;
        }

        #endregion


        #region SetGet

        public int IdJob
        {
            set { idJob = value; }
            get { return idJob;  }
        }
        public string Title
        {
            set { title = value; }
            get { return title;  }
        }
        public string Remote
        {
            set { remote = value; }
            get { return remote;  }
        }
        public string Observation
        {
            set { observation = value; }
            get { return observation;  }
        }
        public DateTime StartDate
        {
            set { startDate = value; }
            get { return startDate;  }
        }
        public DateTime DueDate
        {
            set { dueDate = value; }
            get { return dueDate;  }
        }
        public DateTime FinishDate
        {
            set { finishDate = value; }
            get { return finishDate;  }
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
        public Search Search
        {
            set { search = value; }
            get { return search; }
        }
        public Offer Offer
        {
            set { offer = value; }
            get { return offer; }
        }
        public Status Status
        {
            set { status = value; }
            get { return status; }
        }
        public Tech Tech
        {
            set { technoloy = value; }
            get { return technoloy; }
        }
        public Invoice Invoice
        {
            set { invoice = value; }
            get { return invoice; }
        }
        public Payment Payment
        {
            set { payment = value; }
            get { return payment; }
        }

        #endregion

        #region Overrise ToString

        public override string ToString()
        {
            return "Job: " + Title + StartDate + DueDate + FinishDate;
        }
        #endregion

    }
}