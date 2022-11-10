using Autentication.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Autentication.Controllers
{
    public class Login : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult GirisYap()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(Admin p) //Giris  Yap sayfamın ekrana gelmesinin ardından post işlemini gerçekleştirecek yapı
        {
            var bilgiler = c.Admins.FirstOrDefault(x=>x.Kullanici==p.Kullanici && x.Password ==p.Password);
            //Textbox da yazılanları cookie tarafında eşliyorum.
            if(bilgiler != null)//eğer textler boş gelmezse
            {
                var claims = new List<Claim> //claim yapımı oluşturuyorum
                {
                    new Claim(ClaimTypes.Name,p.Kullanici)
                };

                var useridentity = new ClaimsIdentity(claims, "Login");//identity tanımlaması yapıp loginden aldırıyorum
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);//buradaki principal benim sorgu alanım
                //ve bu alanda ben loginden gelen şeyleri soruguluyorum
                await HttpContext.SignInAsync(principal);//await kullanıp işem sıramı düzenledim 
                return RedirectToAction("Index", "Personel");//eğer burdan gelen veri doğru ise yönlendirme yapsın


            }


            return View();
        }




        public IActionResult Index()
        {
            return View();
        }


    }
}
