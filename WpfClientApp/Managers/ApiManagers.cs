using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WpfClientApp.Managers
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
    public class ApiManagers
    {
        HttpClient client = new HttpClient();
       
        public async void GetValue(string userName)
        {
            client.BaseAddress = new Uri("localhost:3042");
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string str = await client.GetStringAsync("api/values?userName=" + userName);

            Product product = new Product
            {
                Name = "Gizmo",
                Price = 100,
                Category = "Widgets"
            };
        }
    }
}
