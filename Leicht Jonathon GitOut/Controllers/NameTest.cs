using Microsoft.AspNetCore.Mvc;

namespace Leicht_Jonathon_GitOut.Controllers
{
	public class NameTest : Controller
	{
		public JsonResult Name()
		{
			string output = false ? "Jonathon Leicht" : "Jonathon Leicht";

			return Json(output);
		}
	}
}
