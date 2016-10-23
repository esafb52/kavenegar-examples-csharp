using System;
using System.Web.Mvc;

namespace KavenegarExamplesCsharpMvc.Controllers
{
 public class HomeController : Controller
 {
	//
	// GET: /Home/
	public ActionResult Index()
	{
	 try
	 {
		Kavenegar.KavenegarApi api = new Kavenegar.KavenegarApi("Your Api Key");
		var result = api.Send("10006703323323", "09361234567", "خدمات پیام کوتاه کاوه نگار");
		return View(result);
	 }
	 catch (Kavenegar.Exceptions.ApiException ex)
	 {
		// در صورتی که خروجی وب سرویس 200 نباشد این خطارخ می دهد.
		Console.Write("Message : " + ex.Message);
	 }
	 catch (Kavenegar.Exceptions.HttpException ex)
	 {
		// در زمانی که مشکلی در برقرای ارتباط با وب سرویس وجود داشته باشد این خطا رخ می دهد
		Console.Write("Message : " + ex.Message);
	 }
	 return View();
	}
 }
}
