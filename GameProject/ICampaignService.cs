using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign company);
        void Delete(Campaign company);
        void Update(Campaign company);
    }
}
