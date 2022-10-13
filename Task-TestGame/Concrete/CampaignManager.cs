using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_TestGame.Abstract;
using Task_TestGame.Entity;

namespace Task_TestGame.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} isimli kampanya sisteme tanımlandı.", campaign.CampaignName  );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} isimli kampanyada sistemden silindi.", campaign.CampaignName);
        }

        public void MakeDiscount(Games game, Campaign campaign)
        {
            Console.WriteLine("{0} isimli oyuna {1} kampanyası tanımlandı.", game.NameOfGame, campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} isimli kampanyada güncelleme yapıldı.", campaign.CampaignName);
        }
    }
}
