using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign company)
        {
            Console.WriteLine("Kampanya Eklendi.");
        }

        public void Delete(Campaign company)
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void Update(Campaign company)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
