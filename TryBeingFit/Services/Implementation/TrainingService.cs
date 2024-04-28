using Models.Enums;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation
{
    public class TrainingService : ITrainingService
    {
        public void AccessLiveTraining(UserType userType)
        {
            throw new NotImplementedException();
        }

        public void AccessVideoTraining(UserType userType)
        {
            throw new NotImplementedException();
        }

        public TimeSpan GetTimeTillNextLiveTraining()
        {
            throw new NotImplementedException();
        }

        public double GetTrainingRating(int trainingId)
        {
            throw new NotImplementedException();
        }
    }
}
