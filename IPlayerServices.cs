using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    public interface IPlayerServices
    {
        void Add(IEntity player);
        void Delete(IEntity player);
        void Update(IEntity player);
    }
}
