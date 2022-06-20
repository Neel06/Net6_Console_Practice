using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersServiceTest
{
    public class AsyncExample
    {
        public async Task<int> add()
        {
            Task<string> TaskUrl = new HttpClient().GetStringAsync("http://portals.synovergetech.com/");
            string result = await TaskUrl;
            return result.Length;
        }
    }
}
