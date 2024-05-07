using Models.Enums;
namespace Services.Interfaces
{
    public interface ITrainingService
    {
        void AccessLiveTraining(UserType userType); 
        void AccessVideoTraining(UserType userType); 
        double GetTrainingRating(int trainingId); 
        TimeSpan GetTimeTillNextLiveTraining();

        

    }
}
