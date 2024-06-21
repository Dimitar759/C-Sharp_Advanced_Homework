using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Trainer : User
    {

        public List<LiveTraining> LiveTrainings { get; set; } = new List<LiveTraining>();
        public List<VideoTraining> VideoTrainings { get; set; } = new List<VideoTraining>();

        public Trainer(int id, string firstName, string lastName, string username, string password, UserType accountType)
            : base(id, firstName, lastName, username, password, accountType) { }

        public void AddVideoTraining(VideoTraining training)
        {
            VideoTrainings.Add(training);
        }

        public void ScheduleLiveTraining(LiveTraining training)
        {
            // Logic to schedule live training
            // For example, set the time for the next live training based on the current time
            training.StartTime = DateTime.Now.AddHours(24); // Schedule for 24 hours from now
            LiveTrainings.Add(training);
        }




    }
}
