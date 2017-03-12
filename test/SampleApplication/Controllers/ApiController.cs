using Microsoft.AspNetCore.Mvc;
using KeyPay;
using KeyPay.Auth;
using KeyPay.DomainModels.V2.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class ApiController : Controller
    {
        public ApiController(IConfigurationRoot configuration)
        {
            baseUrl = configuration["baseurl"];
        }

        private readonly string baseUrl;
        
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("apikey") == null)
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public IActionResult CreateBusiness(CreateBusinessRequest request)
        {
            var api = CreateApiClient();
            var business = api.Business.Create(new BusinessModel()
            {
                ABN = request.ABN,
                StandardHoursPerDay = request.StandardHoursPerDay,
                Name = request.BusinessName,
                ContactName = request.ContactName,
                ContactEmailAddress = request.ContactEmail
            });

            return Json(business);

        }

        public IActionResult LoadBusinesses()
        {
            var api = CreateApiClient();
            var business = api.Business.List();

            return Json(business);
        }

        public IActionResult LoadBusinessDetails(int id)
        {
            var api = CreateApiClient();
            var payCategories = api.PayCategory.List(id);
            var leaveCategories = api.LeaveCategory.List(id);
            var employees = api.Employee.List(id);

            return Json(new { payCategories, leaveCategories, employees });
        }

        private KeyPayApiV2Client CreateApiClient()
        {
            var api = new KeyPayApiV2Client(baseUrl, new ApiKeyAuthenticationDetails(HttpContext.Session.GetString("apikey")));
            return api;
        }
    }
}