using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TestGame.Entity;

namespace Task_TestGame
{
    public interface IGameBuyManagerService
    {
        void Add(Games game);
        void Buy(Games game,Customer customer);
        void Sell(Games game);
        void SaleWithCampaign(Customer customer, Games game, Campaign campaign);
    }
}
