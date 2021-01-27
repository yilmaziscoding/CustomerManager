using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    public interface IGameServices
    {
        void Add(IEntity game);
        void Delete(IEntity game);
        void Update(IEntity game);
    }
}
