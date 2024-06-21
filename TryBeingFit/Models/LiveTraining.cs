using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LiveTraining : Training
    {
        public DateTime StartTime { get; set; }

        public LiveTraining(TrainingType type, double rating, TimeSpan duration, TimeSpan timeTillNextLiveTraining)
            : base(type, rating, duration, timeTillNextLiveTraining)
        {
        }
    }
}
