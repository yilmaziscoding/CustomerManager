using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    public interface ILoggerServices
    {
        void Add(IEntity entity);
        void Delete(IEntity entity);
        void Update(IEntity entity);

    }
}
