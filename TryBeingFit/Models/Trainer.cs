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

        public List<LiveTraining> LiveTrainings { get; set; }
        public List<VideoTraining> VideoTrainings { get; set; }
        public Trainer(int id, string firstName, string lastName, string username, string password, UserType accountType)
        : base(id, firstName, lastName, username, password, accountType)
        {

        }

        
       

    }
}
