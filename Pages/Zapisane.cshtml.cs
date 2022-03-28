using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie3.Pages.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace Zadanie3.Pages
{
    public class ZapisaneModel : PageModel
    {
        public Forms Forms { get; set; }
        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
                Forms =
                JsonConvert.DeserializeObject<Forms>(Data);
        }
    }
}
