using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1984,
                FirstName = "Engin",
                LastName = "Demiroğ",
                IdentityNumber=12345
            });


            GamerManager gamerManager2 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager2.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Engin",
                LastName = "Demiroğ",
                IdentityNumber = 12345
            });

            Console.ReadLine();
        }
    }
}
