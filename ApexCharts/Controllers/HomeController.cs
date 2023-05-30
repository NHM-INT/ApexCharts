using ApexCharts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApexCharts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("populategraph")]
        [HttpPost]
        public JsonResult PopulateGraph(string ChartType)
        {
            List<Array> DataList = new List<Array>();
            try
            {
                if (ChartType == "Population Growth")
                {
                    string[] DataArray = { "50000", "25000", "85000", "250000", "200000" };
                    string[] CategoryArray = { "2000", "2010", "2020", "5_Year_Proj", "10_Year_Proj" };
                    DataList.Add(DataArray);
                    DataList.Add(CategoryArray);
                }
                if (ChartType == "Household Income")
                {
                    string[] DataArray = { "45000", "20000", "15000", "180000", "140000", "5000", "100000", "20000","22000","17000" };
                    string[] CategoryArray = { "0-10K", "10-15K", "15-25K", "25-35K", "35-50K", "50-75K", "75-100K", "100-150K", "150-200K", "200K+" };
                    DataList.Add(DataArray);
                    DataList.Add(CategoryArray);
                }
                if (ChartType == "Ethnicity")
                {
                   
                    Double[] DataArray = { 10,25,12,5,14,11,35,18 };


                    string[] CategoryArray = { "White", "Black", "Indian", "Asian", "Hawaiian", "Hispanic", "Other-Race", "Multi-Race" };
                    DataList.Add(DataArray);
                    DataList.Add(CategoryArray);
                }
                if (ChartType == "Rent")
                {
                    
                    string[] DataArray = { "6000","8500","10000" };
                    string[] CategoryArray = { "Avg-Rent","Mid-Rent","High-Rent" };
                    DataList.Add(DataArray);
                    DataList.Add(CategoryArray);
                }
                if (ChartType == "Revenue")
                {

                    double[] DataArray1 = { 31, 40, 28, 51, 42, 109, 100 };
                    double[] DataArray2 = { 11, 32, 45, 32, 34, 52, 41 };
                    string[] CategoryArray = { "2023-05-19T00:00:00.000Z", "2023-05-19T01:30:00.000Z", "2023-05-19T02:30:00.000Z", "2023-05-19T03:30:00.000Z", "2023-05-19T04:30:00.000Z", "2023-05-19T05:30:00.000Z", "2023-05-19T06:30:00.000Z" };
                    DataList.Add(DataArray1);
                    DataList.Add(DataArray2);
                    DataList.Add(CategoryArray);
                }
                if (ChartType == "Source")
                {

                    double[] DataArray1 = { 440, 505, 414, 671, 227, 413, 201, 352, 752, 320, 257, 160 };
                    double[] DataArray2 = { 23, 42, 35, 27, 43, 22, 17, 31, 22, 22, 12, 16 };
                    string[] CategoryArray = { "01 Jan 2023", "02 Jan 2023", "03 Jan 2023", "04 Jan 2023", "05 Jan 2023", "06 Jan 2023", "07 Jan 2023", "08 Jan 2023", "09 Jan 2023", "10 Jan 2023", "11 Jan 2023", "12 Jan 2023" };
                    DataList.Add(DataArray1);
                    DataList.Add(DataArray2);
                    DataList.Add(CategoryArray);
                }
            
            }
            catch (Exception e)
            {

            }
            return Json(DataList);

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