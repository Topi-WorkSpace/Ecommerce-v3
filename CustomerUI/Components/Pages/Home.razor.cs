
using Domain.Models;
using Newtonsoft.Json;

namespace CustomerUI.Components.Pages
{
    public partial class Home
    {
        IEnumerable<Product> products = new List<Product>();
        IEnumerable<Category> categories = new List<Category>();    

        protected override async Task OnInitializedAsync()
        {

            //gọi api lấy danh sách product
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync($"https://localhost:7206/api/Product/Products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<IEnumerable<Product>>(apiResponse); 
                }
            }

            //gọi api lấy danh sách category
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync($"https://localhost:7206/api/Category/Categories"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(apiResponse);
                }
            }

        }


    }
}
