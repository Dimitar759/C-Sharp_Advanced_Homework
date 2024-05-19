using DataAccess;
using Models.Enums;
using System.Collections.Generic;

namespace Models
{
    public class Storage
    {
        public static StorageSet<Client> Clients { get; set; }
        public static StorageSet<Trainer> Trainers { get; set; }

        static Storage()
        {
            string clientsFilePath = @"C:\Users\dimit\OneDrive\Documents\GitHub\C-Sharp_Advanced_Homework\TryBeingFit\ClientsFile\clients.json"; // Update this path to your specified folder
            string trainersFilePath = @"C:\Users\dimit\OneDrive\Documents\GitHub\C-Sharp_Advanced_Homework\TryBeingFit\TrainersFile\trainers.json"; // Update this path to your specified folder

            // Ensure the directories exist
            Directory.CreateDirectory(Path.GetDirectoryName(clientsFilePath));
            Directory.CreateDirectory(Path.GetDirectoryName(trainersFilePath));

            Clients = new StorageSet<Client>(clientsFilePath);
            Trainers = new StorageSet<Trainer>(trainersFilePath);

            if (!Trainers.GetAll().Any())
            {
                Trainers.Add(new Trainer(0, "Trainer", "Trainer", "trainer123", "trainer123", UserType.Trainer));
            }
        }
    }
}