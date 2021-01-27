using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class GamerManager : IGameServices
    {
        private List<ILoggerServices> _loggerServices;
        private IPersonCheckServices _personCheckServices;

        public GamerManager(IPersonCheckServices personCheckService, List<ILoggerServices> loggerServices)
        {
            _personCheckServices = personCheckService;
            _loggerServices = loggerServices;
        }

        public void Add(IEntity player)
        {
            if (_personCheckServices.CheckIfRealPerson((Person)player))
            {
                foreach (var logger in _loggerServices)
                {
                    logger.Add(player);
                }
            }
            else
            {
                throw new Exception($"{player.Name} is invalid.");
            }
        }

        public void Delete(IEntity player)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(player);
            }
        }

        public void Update(IEntity player)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(player);
            }
        }


    }
}