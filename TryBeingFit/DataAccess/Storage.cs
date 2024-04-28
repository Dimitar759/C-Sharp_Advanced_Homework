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
        public static StorageSet<User> Users = new StorageSet<User> ();
        public static StorageSet<Trainer> Trainers = new StorageSet<Trainer> ();
    }
}
