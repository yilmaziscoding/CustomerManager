using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class DatabaseLoggerManager : ILoggerServices
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} added to database.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} deleted from database.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} is updated.");
        }
    }
}

