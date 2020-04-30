using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Lab6Service;


namespace Lab8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Reviews()
        {
            RestaurantReviewServiceClient reviewer = new RestaurantReviewServiceClient();
            RestaurantInfo[] restInfos = await reviewer.GetRestaurantsByRatingAsync(0);
            Models.RestaurantInfo[] restaurantInfos = new
            Models.RestaurantInfo[restInfos.Length];
            for (int i = 0; i < restInfos.Length; i++)
            {
                restaurantInfos[i] = new Models.RestaurantInfo();
                restaurantInfos[i].Name = restInfos[i].Name;
                restaurantInfos[i].Summary = restInfos[i].Summary;
                restaurantInfos[i].Rating = int.Parse(restInfos[i].Rating);
                restaurantInfos[i].Location = new Models.Address();
                restaurantInfos[i].Location.Street = restInfos[i].Location.Street;
                restaurantInfos[i].Location.City = restInfos[i].Location.City;
                restaurantInfos[i].Location.Province = restInfos[i].Location.Province;
                restaurantInfos[i].Location.PostalCode = restInfos[i].Location.PostalCode;
            }
            //Note: This method generates Json object property names starting with
            //lower case (camelCase) regardless the case of the corresponding C#
            //object property names!
            return Json(restaurantInfos);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateReview(string restInfo)
        {
            if (!string.IsNullOrWhiteSpace(restInfo))
            {
                Models.RestaurantInfo restaurantInfo =
                JsonConvert.DeserializeObject<Models.RestaurantInfo>(restInfo);
                RestaurantInfo info = new RestaurantInfo();
                info.Name = restaurantInfo.Name;
                info.Summary = restaurantInfo.Summary;
                info.Rating = restaurantInfo.Rating.ToString();
                info.Location = new Address();
                info.Location.Street = restaurantInfo.Location.Street;
                info.Location.City = restaurantInfo.Location.City;
                info.Location.Province = restaurantInfo.Location.Province;
                info.Location.PostalCode = restaurantInfo.Location.PostalCode;
                RestaurantReviewServiceClient reviewer = new
                RestaurantReviewServiceClient();
                if (await reviewer.SaveRestaurantAsync(info))
                {
                    return Json("Updated restaurant review has been saved!");
                }
            }
            return Json("No data received!");
        }

    }
}