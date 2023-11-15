using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Text.Json;
using JsonObject = System.Text.Json.Nodes.JsonObject;

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
            try
            {
                var client = new RestClient(uri);
                var request = new RestRequest();

                request.Method = RestSharp.Method.GET;
                request.AddQueryParameter("app_id", appId);
                request.AddQueryParameter("app_key", appKey);
                request.AddQueryParameter("nutrition-type", "cooking");
                request.AddQueryParameter("ingr", foodname);
                IRestResponse response = client.Execute(request);
                JsonObject obj = (JsonObject)JsonObject.Parse(response.Content);

                food.Calorie = (float)obj["calories"];
                JsonObject nutrient = (JsonObject)obj["totalNutrients"];
                if (nutrient.ToString() == "{}") throw new Exception();
                food.Fat = (float)nutrient["FAT"]["quantity"];
                food.Carbohydrate = (float)nutrient["CHOCDF.net"]["quantity"];
                food.Protein = (float)nutrient["PROCNT"]["quantity"];

                return food;
            }
            catch (Exception ex)
            {
                MessageBox.Show("food not found");
                return food;
            }
        }
    }
}
