using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //microservice
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız, Kayıt Başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Silindi");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız, Silme Başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Güncellendi");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız, Güncelleme Başarısız");
            }
        }
    }
}
