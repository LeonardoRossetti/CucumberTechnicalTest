using CucumberTechnicalTest.Helper;
using CucumberTechnicalTest.Models;
using System;
using System.Web.Mvc;

namespace CucumberTechnicalTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new ConvertModel());
        }

        [HttpPost]
        public ActionResult Index(ConvertModel model)
        {
            ConvertModel convertModel = new ConvertModel();

            if (ModelState.IsValid)
            {
                String numberInWords = Converter.ConvertToWords(model.Number);
                convertModel.Result = new ResultModel(model.Name, numberInWords);
            }

            return View(convertModel);
        }
    }
}