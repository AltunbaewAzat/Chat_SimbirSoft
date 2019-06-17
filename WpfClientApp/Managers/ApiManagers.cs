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
        public bool GetValue(string userName, string password)
        {
            client.BaseAddress = new Uri("http://localhost:30766");
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string str = client.GetStringAsync(String.Format("api/values?userName={0}&password={1}", userName, password)).Result;
            UserInfo serverInfo = JsonConvert.DeserializeObject<UserInfo>(str);
            if(serverInfo.Id!=0)
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
