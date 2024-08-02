using CustomerPortal.Client.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CustomerPortal.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly string baseURL = "https://localhost:7273/api/";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            DataTable ?customerDataTable = new DataTable();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getCustomers = await client.GetAsync("Customer");

                if (getCustomers.IsSuccessStatusCode)
                {
                    string customerList = getCustomers.Content.ReadAsStringAsync().Result;
                    customerDataTable = JsonConvert.DeserializeObject<DataTable>(customerList);
                }
                else
                {
                    Console.WriteLine("Error loading data");
                }

                ViewData.Model = customerDataTable;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
