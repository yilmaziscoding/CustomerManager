using System;
using System.Collections.Generic;

namespace GameSalesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonCheckServices personCheck = new PersonCheckManager();
            ILoggerServices databaseLogger = new DatabaseLoggerManager();
            ILoggerServices fileLogger = new FileLoggerManager();

            List<ILoggerServices> loggerServices = new List<ILoggerServices>() { fileLogger };

            IPlayerServices playerManager = new PlayerManager(personCheck, loggerServices);

            IEntity yilmaz = new Gamer() { FirstName = "Yilmaz", LastName = "Soysal", UserName = "ylmzsysl", Password = "123456789", BirthDate = new DateTime(1999, 11, 20), CitizenshipId
                = "11112222333" };
            IEntity engin = new Gamer() { FirstName = "Engin", LastName = "Demirog", UserName = "engindemirog", Password = "123456789", BirthDate = new DateTime(1999, 11, 20), CitizenshipId = "11112222333" };
            IEntity riot = new Gamer() { FirstName = "Riot", LastName = "Games", UserName = "riotgames", Password = "123456789", BirthDate = new DateTime(2007, 01, 6), CitizenshipId = "11112222333" };

            playerManager.Add(yilmaz);
            playerManager.Add(engin);
            playerManager.Add(riot);



            IEntity valorant = new Game() { Name = "Valorant", Price = (double)59.90 };
            IEntity csgo = new Game() { Name = "PUBG", Price = (double)79.90 };
           

            IGameServices gameManager = new GameManager(loggerServices);

            gameManager.Add(valorant);
            gameManager.Add(csgo);
            




            ISalesService winterSales = new BlackFridaySalesManager(loggerServices);


            IPlatformServices platformManager = new RiotPlatformManager(new List<ISalesService> { winterSales });
            platformManager.BuyGameFromPlayer(yilmaz, valorant);
            platformManager.BuyGameFromPlayer(engin, csgo);
            platformManager.BuyGameFromPlayer(riot, valorant);
            


            Console.ReadLine();
        }
    }
}
