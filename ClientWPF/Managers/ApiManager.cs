using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientWPF.Managers
{
    public class ApiManager
    {
        HttpClient client = new HttpClient() {
            BaseAddress = new Uri("localhost:3042"),
            MaxResponseContentBufferSize = 256000 };

        public async void GetValue(string userName)
        {
            string str = await client.GetStringAsync("api/values?userName=" + userName);
            
        }
    }
}
