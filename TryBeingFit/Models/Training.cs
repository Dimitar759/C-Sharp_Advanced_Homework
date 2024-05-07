using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;

namespace Models
    //live and video training posebno napravi gi
{
    public abstract class Training 
    {

        public Training(TrainingType type, double rating, TimeSpan duration, TimeSpan timeTillNextLiveTraining)
        {
            Type = type;
            Rating = rating;
            Duration = duration;
            TimeTillNextLiveTraining = timeTillNextLiveTraining;
        }

        public TrainingType Type { get; set; }
        public double Rating { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan TimeTillNextLiveTraining { get; set; }
        public Trainer Trainer { get; set; }
    }
}
