using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RetryApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Values { get; set; }
        public async Task OnGet(/*[FromServices]IHttpClientFactory factory*/)
        {
            var client = new HttpClient();
            Values = await client.GetStringAsync("https://localhost:44338/api/values");
        }
    }
}
