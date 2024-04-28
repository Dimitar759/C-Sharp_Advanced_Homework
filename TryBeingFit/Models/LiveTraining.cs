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
        public TrainingType Type { get; set ; }
        public double Rating { get ; set; }
        public TimeSpan Duration { get ; set ; }
        public TimeSpan TimeTillNextLiveTraining { get ; set; }
    }
}
