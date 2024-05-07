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
            if (userType == UserType.Premium)
            {

            }
            else
            {
                // Deny access for normal users
                Console.WriteLine("Access to live training is available only for premium users.");
            }
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
