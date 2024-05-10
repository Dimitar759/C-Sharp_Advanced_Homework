using Models;
using Models.Enums;
using DataAccess;
using System;
using Services.Implementation;
using Services.Interfaces;

namespace TryBeingFit
{
    public class Program
    {
        static MenuService menuService = new MenuService();
        static UserService userService = new UserService();
        static TrainingService trainingService = new TrainingService();
        static void Main(string[] args)
        {

            //Client newUser   = new Client(0, "John", "Doe", "john123", "password123", UserType.Standard);
            //Trainer newTrainer = new Trainer(0, "Ben", "Doe", "john123", "password123", UserType.Trainer);
            //Trainer newTrainer1 = new Trainer(0, "Kevin", "Doe", "john123", "password123", UserType.Trainer);
            //Client newUser1 = new Client(0 , "Gwen", "Doe", "john123", "password123", UserType.Premium);

            //Storage.Clients.Add(newUser);
            //Storage.Trainers.Add(newTrainer);
            //Storage.Trainers.Add(newTrainer1);
            //Storage.Clients.Add(newUser1);

            //foreach (var client in Storage.Clients.GetAll())
            //{
            //    Console.WriteLine($"ID: {client.Id}, Name: {client.FirstName} {client.LastName}, Username: {client.Username}, Account Type: {client.AccountType}");
            //}

            //foreach (var client in Storage.Trainers.GetAll())
            //{
            //    Console.WriteLine($"ID: {client.Id}, Name: {client.FirstName} {client.LastName}, Username: {client.Username}, Account Type: {client.AccountType}");
            //}



            while (true)
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Log In");
                Console.WriteLine("Choose an option: ");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        Console.WriteLine("Enter first name: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter last name: ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter username: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        string password = Console.ReadLine();
                        bool registered = userService.Register(firstName, lastName, username, password);
                        if (registered)
                        {
                            Console.WriteLine("Registration successful.");
                        }
                        else
                        {
                            Console.WriteLine("Registration failed. Please try again.");
                        }
                        break;

                    case "2":

                        Console.WriteLine("Enter username: ");
                        string loginUsername = Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        string loginPassword = Console.ReadLine();
                        bool loggedIn = userService.Login(loginUsername, loginPassword);
                        if (loggedIn)
                        {
                            Console.WriteLine("Login successful.");

                        }
                        else
                        {
                            Console.WriteLine("Login failed. Please check your credentials and try again.");
                        }
                        break;

                    case "3":
                        userService.LogOut();
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                if (CurrentSession.CurrentUser != null)
                {
                    string accountType = userService.Account();
                    DisplayMenu(accountType);


                    if (accountType == "Standard")
                    {
                        HandleStandardUserChoice();
                    }

                    if (accountType == "Premium")
                    {
                        HandlePremiumUserChoice();
                    }

                    if (accountType == "Trainer")
                    {
                        HandleTrainerChoice();
                    }
                }


            }
        }

        static void DisplayMenu(string accountType)
        {
            switch (accountType)
            {
                case "Standard User":
                    menuService.UserMenu();
                    break;

                case "Premium User":
                    menuService.PremiumUserMenu();
                    break;

                case "Trainer":
                    menuService.TrainerMenu();
                    break;

                default:
                    Console.WriteLine("Unknown Account Type.");
                    break;
            }
        }


        static void HandleStandardUserChoice()
        {
            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    userService.Train();
                    break;

                case "2":
                    userService.UpgradeToPremium();
                    break;

                case "3":
                    userService.Account();
                    break;

                case "4":
                    userService.LogOut();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void HandlePremiumUserChoice()
        {
            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    userService.Train();
                    break;

                case "2":
                    userService.Account();
                    break;

                case "3":
                    userService.LogOut();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void HandleTrainerChoice()
        {
            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    userService.RescheduleTraining();
                    break;

                case "2":
                    userService.Account();
                    break;

                case "3":
                    userService.Train();
                    break;

                case "4":
                    userService.LogOut();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}   
