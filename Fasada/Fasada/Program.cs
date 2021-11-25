
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WzorzecFasada
{

    interface IUserService
    {
        int Counter { get; }
        void CreateUser(string email);
        void RemoveUser(string email);
    }

    static class EmailNotification
    {
        public static void SendEmail(string to, string subject)
        {
            Console.WriteLine($"{subject} {to}");
        }
    }

    class UserRepository
    {
        public int Counter => users.Count;
        private readonly List<string> users = new List<string>
        {
            "john.doe@gmail.com", "sylvester.stallone@gmail.com"
        };


        public bool IsEmailFree(string email)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (email == users[i])
                {
                    return false;
                }
            }
            return true;
        }

        public void AddUser(string email)
        {
            if (IsEmailFree(email) == true)
            {
                users.Add(email);
            }
        }
        public void RemoveUser(string email)
        {
            users.Remove(email);
        }
    }
        static class Validators
        {
            public static bool IsValidEmail(string email)
            {
                return Regex.IsMatch(email,
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                        RegexOptions.IgnoreCase);
            }
        }

        class UserService : IUserService
        {
            public int Counter => userRepository.Counter;
            private readonly UserRepository userRepository = new UserRepository();

            public void CreateUser(string email)
            {
                if (!Validators.IsValidEmail(email))
                {
                    throw new ArgumentException("Błędny email");
                }

                if (userRepository.IsEmailFree(email) == false)
                {
                    throw new ArgumentException("Email zajęty");
                }
                // TODO: dodaj sprawdzenie czy email jest wolny, jeśli nie to wyrzuć wyjątek, jeśli tak, kontynuuj wykonywanie funkcji

                userRepository.AddUser(email);
                EmailNotification.SendEmail(email, "Welcome to our service");
            }

            public void RemoveUser(string email)
            {
                if (userRepository.IsEmailFree(email))
                {
                    throw new ArgumentException("Błędny email");
                }
            userRepository.RemoveUser(email);
            EmailNotification.SendEmail(email, "Goodbye");
        }
            
        }

        class Program
        {
            static void Main(string[] args)
            {
                IUserService userService = new UserService();
                Console.WriteLine($"Aktualna liczba adresow: {userService.Counter}");
                userService.CreateUser("someemail@gmail.com");
                Console.WriteLine($"Aktualna liczba adresow: {userService.Counter}");
                userService.RemoveUser("john.doe@gmail.com");
                Console.WriteLine($"Aktualna liczba adresow: {userService.Counter}");
            // TODO: usunąć użytkownika
            // TODO: wyświetlić liczbę
        }
        }

    }
