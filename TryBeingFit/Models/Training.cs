using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;

namespace Models
{
    public class Training
    {
        public TrainingType Type { get; set; }
        public double Rating { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan TimeTillNextLiveTraining { get; set; }

        public Training(double rating, TimeSpan duration, TimeSpan tillNextLiveTraining)
        {
            Type = TrainingType.Live; 
            Rating = rating;
            Duration = duration;
            TimeTillNextLiveTraining = tillNextLiveTraining;
        }

        public Training(double rating, TimeSpan duration)
        {
            Type = TrainingType.Live;
            Rating = rating;
            Duration = duration;
        }
    }
}
