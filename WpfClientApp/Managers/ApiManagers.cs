using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WpfClientApp.Managers
{
    public class ApiManagers
    {
        HttpClient client = new HttpClient();
        //HttpResponseMessage response = new HttpResponseMessage();
        public bool GetValue(string userName, string password)
        {
            client.BaseAddress = new Uri("http://localhost:30766");
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string answer = client.GetStringAsync(string.Format("api/values?userName={0}&password={1}", userName, password)).Result;
            UserWpf serverInfo = JsonConvert.DeserializeObject<UserWpf>(answer);
            if(serverInfo.Id!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PostValue(UserWpf userValue)
        {
            client.BaseAddress = new Uri("http://localhost:30766");
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync("api/values/", userValue).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
