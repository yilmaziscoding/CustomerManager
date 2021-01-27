using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class FileLoggerManager : ILoggerServices
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} is added to file.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine($"{entity.Name} is deleted from file.");

        }

        public void Update(IEntity entity)
        {
            Console.WriteLine($"File {entity.Name} is updated.");
        }
    }
}

