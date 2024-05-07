using DataAccess;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Storage
    {
        public static StorageSet<Client> Clients { get; set; }
        public static StorageSet<Trainer> Trainers { get; set; }

        static Storage()
        {
            Clients = new StorageSet<Client>();
            Trainers = new StorageSet<Trainer>();

           
            if (!Trainers.GetAll().Any())
            {
                Trainers.Add(new Trainer(0, "Trainer", "Trainer", "trainer123", "trainer123", UserType.Trainer));
            }
        }
    }
}
