using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class GameManager:IGameServices
    {
        private List<ILoggerServices> _loggerServices;

        public GameManager(List<ILoggerServices> loggerServices)
        {
            this._loggerServices = loggerServices;
        }

        public void Add(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }

        public void Delete(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(game);
            }
        }

        public void Update(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(game);
            }
        }
    }
}
    

