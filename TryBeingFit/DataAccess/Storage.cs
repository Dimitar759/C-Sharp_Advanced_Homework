using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Storage
    {
        public static StorageSet<Client> Clients = new StorageSet<Client> ();
        public static StorageSet<Trainer> Trainers = new StorageSet<Trainer> ();
    }
}
