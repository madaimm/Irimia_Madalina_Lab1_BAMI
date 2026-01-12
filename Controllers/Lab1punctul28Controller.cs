using Microsoft.AspNetCore.Mvc;

namespace Irimia_Madalina_Lab1_BAMI.Controllers
{
    public class Lab1punctul28Controller : Controller
    {
        public string Index()
        {
            return "Bine ai venit la primul meu laborator de ASP.NET Core MVC!";
        }

      
        public string Salutare()
        {
            return "Salut! Sunt Madalina.";
        }

        public string InfoUtilizator(string nume)
        {
            
            DateTime dataCurenta = DateTime.Now;

            return "Salut " + nume + "! Ai accesat această pagină în data de: " + dataCurenta.ToString();
        }
    }
}