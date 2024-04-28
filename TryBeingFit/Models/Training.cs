using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;

namespace Models
    //live and video training posebno napravi gi
{
    public interface Training 
    {
        public TrainingType Type { get; set; }
        public double Rating { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan TimeTillNextLiveTraining { get; set; }

        
    }
}
