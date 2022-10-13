using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Task_TestGame.Concrete;
using Task_TestGame.Entity;
using Task_TestGame.MernisServiceReference;

namespace Task_TestGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> games = new List<string>() {"League Of Legends", "Minecraft", "Forza","GAME*GAME*GAME" };
            //Customer customer1 = new Customer {DateOfBirth = new DateTime(2004, 8, 23),FirstName ="Burak",LastName="Kocadağ", Id = 1 ,NationalityId = "12121212121" };
            //Customer customer2 = new Customer {DateOfBirth = new DateTime( 2006,1,2), FirstName = "Şenol", LastName = "Atar", Id = 2, NationalityId = "13579246802" };
            //Customer customer3 = new Customer { DateOfBirth = new DateTime(1998, 6, 17), FirstName = "Esma", LastName = "Liva", Id = 1, NationalityId = "30025078156" };
            //customer1.Add(customer1);
            //Customer[] customers = new Customer[] { customer1, customer2, customer3 };


            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.DateOfBirth+" "+customer.NationalityId);
            //}
            CustomerManager customerManager = new CustomerManager(new TcIdentify());

            GameManager gameManager = new GameManager();

            CampaignManager campaignManager = new CampaignManager();
            
            Customer customer1 = new Customer { DateOfBirth = new DateTime(2004, 8, 23), FirstName = "Burak", LastName = "Kocadağ", Id = 1, NationalityId = "12121212121" };
           
                customerManager.Add(customer1);

                Games game1 = new Games() { GameId = 1, NameOfGame = "Gta V", MoneyOfGame = 75 };

                gameManager.Add(game1);

                gameManager.Buy(game1, customer1);

                Campaign campaign1 = new Campaign() { CampaignId = 1, CampaignName = "Yılbaşı Özel", DiscountRate = 0.1f };

                gameManager.SaleWithCampaign(customer1, game1, campaign1);



            Console.ReadKey();
        }
    }
}
