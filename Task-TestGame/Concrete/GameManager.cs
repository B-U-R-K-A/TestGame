using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TestGame.Entity;

namespace Task_TestGame.Concrete
{
    public class GameManager : IGameBuyManagerService
    {
        public void Buy(Games game,Customer customer)
        {
            Console.WriteLine("{0} isimli oyun {1} isimli oyuncu tarafından satın alındı.", game.NameOfGame, customer.FirstName + " " + customer.LastName);
        }

        public void SaleWithCampaign(Customer customer, Games game, Campaign campaign)
        {
            Console.WriteLine("{0} isimli oyun {1} isimli oyuncu tarafından {2} kampanyası dahilinde %{3} indirimle satın alındı.",
               game.NameOfGame, customer.FirstName + " " + customer.LastName, campaign.CampaignName, campaign.DiscountRate * 100);
        }

        public void Sell(Games game)
        {
            Console.WriteLine("Oyun satıldı. Paranız hesabınıza yüklenmiştir..");
        }

        public void Add(Games game)
        {
            Console.WriteLine("{0} isimli oyun sisteme eklendi.", game.NameOfGame);
        }

    }
}
