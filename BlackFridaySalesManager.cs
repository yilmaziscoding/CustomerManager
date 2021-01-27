using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class BlackFridaySalesManager:ILoggerServices
    {
        private List<ILoggerServices> _loggerServices;

        public BlackFridaySalesManager(List<ILoggerServices> loggerServices)
        {
            _loggerServices = loggerServices;
        }
        public void GamePriceAfterDiscount(Game game)
        {
            game.Price *= (double)0.70;
        }
    }
}

        

