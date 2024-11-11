using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();                                    //Yetenek Sayısı
			ViewBag.v2 = context.Messages.Count();                                  //Toplam Mesaj Sayısı
			ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();           //Okunmayan Mesaj
			ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();            //Okunan Mesaj

			ViewBag.v5 = context.Experiences.Count();
			ViewBag.v6 = context.socialMedias.Count();
			return View();
		}
	}
}
