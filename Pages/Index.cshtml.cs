using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zadanie3.Pages.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Zadanie3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Forms Forms { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Data",
                JsonConvert.SerializeObject(Forms));
                (ViewData["Message"], ViewData["MessageClass"]) = Forms.getOutput();
                return RedirectToPage("./Zapisane");
            }

            return Page();
        }
    }
}