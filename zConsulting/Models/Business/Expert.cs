using System.Collections.Generic;

namespace zConsulting.Models.Business
{
    public class Activity
    {
        public string Name { get; set; }
    }
    public class Expert
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortDescription { get; set; }
        public string Position { get; set; }
        public IList<Activity> Activities { get; set; }
        public string Photo { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }

    public class ExpertViewModel
    {
        public string Title { get; set; }

        public ExpertViewModel(IList<Expert> experts)
        {
            Experts = experts;
            CurrentRow = 0;
        }

        public IList<Expert> Experts { get; private set; }

        public int CurrentRow { get; set; }
    }
}
