﻿using DataAccess;
using Models;
using Models.Enums;
using Services.Interfaces;
using System;
using System.Linq;

namespace Services.Implementation
{
    public class UserService : IUserService
    {
        private Storage _storage;

        public UserService()
        {
            _storage = new Storage();
        }

        public string Account()
        {
            if (CurrentSession.CurrentUser == null)
            {
                return "No user logged in.";
            }

            switch (CurrentSession.CurrentUser.AccountType)
            {
                case UserType.Standard:
                    return "Standard User";
                case UserType.Premium:
                    return "Premium User";
                case UserType.Trainer:
                    return "Trainer";
                default:
                    return "Unknown Account Type";
            }
        }

        public bool Login(string username, string password)
        {
            var client = Storage.Clients.GetAll().FirstOrDefault(u => u.Username == username && u.Password == password);
            if (client != null)
            {
                CurrentSession.CurrentUser = client;
                return true;
            }

            var trainer = Storage.Trainers.GetAll().FirstOrDefault(u => u.Username == username && u.Password == password);
            if (trainer != null)
            {
                CurrentSession.CurrentUser = trainer;
                return true;
            }

            return false;
        }

        public void LogOut()
        {
            CurrentSession.CurrentUser = null;
        }

        public bool Register(string firstName, string lastName, string username, string password)
        {
            if (!ValidateUserInput(firstName, lastName, username, password))
            {
                return false;
            }

            if (IsUsernameTaken(username))
            {
                return false;
            }

            var newUser = new Client(0, firstName, lastName, username, password, UserType.Standard);
            CurrentSession.CurrentUser = newUser;

            Storage.Clients.Add(newUser);
            return true;
        }

        private bool IsUsernameTaken(string username)
        {
            return Storage.Clients.GetAll().Any(u => u.Username == username);
        }

        public bool ValidateUserInput(string firstName, string lastName, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || firstName.Length < 2 || lastName.Length < 2)
            {
                Console.WriteLine("Please enter a first name and last name with a minimum of 2 characters");
                return false;
            }

            if (string.IsNullOrWhiteSpace(username) || username.Length < 6)
            {
                Console.WriteLine("Please enter a username with a minimum of 6 characters");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6 || !password.Any(char.IsDigit))
            {
                Console.WriteLine("Please enter a password with a minimum of 6 characters and at least 1 number");
                return false;
            }

            return true;
        }

        public bool UpgradeToPremium()
        {
            if (CurrentSession.CurrentUser == null || CurrentSession.CurrentUser.AccountType != UserType.Standard)
            {
                return false;
            }

            CurrentSession.CurrentUser.AccountType = UserType.Premium;
            Storage.Clients.Update((Client)CurrentSession.CurrentUser);
            return true;
        }

        public void ViewSchedule()
        {
            if (CurrentSession.CurrentUser is Trainer trainer)
            {
                Console.WriteLine("Live Trainings:");
                foreach (var training in trainer.LiveTrainings)
                {
                    Console.WriteLine($"Start Time: {training.StartTime}, Duration: {training.Duration}");
                }

                Console.WriteLine("Video Trainings:");
                foreach (var training in trainer.VideoTrainings)
                {
                    Console.WriteLine($"Duration: {training.Duration}");
                }
            }
        }
        // For the trainers
        public void RescheduleTraining()
        {
            throw new NotImplementedException();
        }

        public void Train()
        {
            throw new NotImplementedException();
        }
    }
}