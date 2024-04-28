using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ITrainingService
    {
        void LiveTraining();
        void VideoTraining();
        void Rating();
    
    }
}
