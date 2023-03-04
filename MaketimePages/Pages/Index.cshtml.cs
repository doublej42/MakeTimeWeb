using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaketimePages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //We need a place to store the name
        [BindProperty]
        public string MyName { get; set; }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            _logger.LogDebug(MyName);
        }

    }
}