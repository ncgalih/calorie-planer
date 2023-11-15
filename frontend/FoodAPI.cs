using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace frontend
{
    internal class FoodAPI
    {
        static string appId = "e5520aa9";
        static string appKey = "86c7f1cb766cb7cbfe146b74b45f6506";
        static string uri = "https://api.edamam.com/api/nutrition-data";

        public static Makanan getFoodInfo(string foodname)
        {
            Makanan food = new Makanan(foodname);

            var client = new RestClient(uri);
            var request = new RestRequest();

            request.Method = Method.Get;
            request.AddQueryParameter("app_id", appId);
            request.AddQueryParameter("app_key", appKey);
            request.AddQueryParameter("nutrition-type", "cooking");
            request.AddQueryParameter("ingr", foodname);

            RestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)JsonObject.Parse(response.Content);

            food.Calorie = (float)obj["calories"];
            food.Fat = (float)obj["totalNutrients"]["FAT"]["quantity"];
            food.Carbohydrate = (float)obj["totalNutrients"]["CHOCDF.net"]["quantity"];
            //.Show((int)(obj["totalNutrients"]["FAT"]["quantity"].ToString()))
            return food;
        }
    }
}
