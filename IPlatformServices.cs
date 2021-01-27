using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    public interface IPlatformServices
    {
        void BuyGameFromPlayer(IEntity player, IEntity game);
        void RefundGameFromPlayer(IEntity player, IEntity game);
    }
}
