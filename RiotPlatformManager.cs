using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class RiotPlatformManager : IPlatformServices
    {
        private List<ISalesService> _salesServices;

        public RiotPlatformManager(List<ISalesService> salesServices)
        {
            _salesServices = salesServices;
        }

        public void BuyGameFromPlayer(IEntity player, IEntity game)
        {
            foreach (var sale in _salesServices)
            {
                sale.DiscountRate((Game)game);
            }
            Console.WriteLine($"{player.Name}, {game.Name} bought from Riot Platform.");
        }

        public void RefundGameFromPlayer(IEntity player, IEntity game)
        {
            Console.WriteLine($"{player.Name}, {game.Name} returned to Riot Platform.");
        }
    }
}

