using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SampleApplication.Models;
using KeyPayV2.Uk;
using KeyPayV2.Common.Auth;
using KeyPayV2.Uk.Models.Business;

namespace SampleApplication.Controllers;

public class ApiController : Controller
{
    public ApiController(IConfiguration configuration)
    {
        _baseUrl = configuration.GetValue<string>("baseurl");
    }

    private readonly string _baseUrl;
        
    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("apikey") == null)
        {
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        return View();
    }

    [HttpPost]
    public IActionResult CreateBusiness(CreateBusinessRequest request)
    {
        var api = CreateApiClient();
        var business = api.Business.CreateNewBusiness(
            new UkBusinessExportModel
            {
                StandardHoursPerDay = request.StandardHoursPerDay,
                Name = request.BusinessName,
                ContactName = request.ContactName,
                ContactEmailAddress = request.ContactEmail,
                Chrn = request.Chrn,
            },
            request
        );

        return Json(business);
    }

    public IActionResult LoadBusinesses()
    {
        var api = CreateApiClient();
        var business = api.Business.ListBusinesses();

        return Json(business);
    }

    public IActionResult LoadBusinessDetails(int id)
    {
        var api = CreateApiClient();

        var payCategories = api.PayCategory.ListPayCategories(id);
        var leaveCategories = api.LeaveCategories.ListLeaveCategories(id);
        var employees = api.Employee.ListBasicDetailsForEmployees(id);
            
        return Json(
            new
            {
                payCategories,
                leaveCategories,
                employees,
            }
        );
    }

    private UkApiClient CreateApiClient()
    {
        var api = new UkApiClient(
            _baseUrl,
            new ApiKeyAuthenticationDetails(HttpContext.Session.GetString("apikey"))
        );

        return api;
    }
}