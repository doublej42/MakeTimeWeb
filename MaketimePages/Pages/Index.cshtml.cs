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

        const int min = 1;
        const int max = 10;

        //We need a place to store the name
        [BindProperty]
        public string MyName { get; set; }

        //[BindProperty]
        public int CorrectAnswer { get; set; }

        [BindProperty]
        public int Guess { get; set; }

        [BindProperty]
        public string Output { get; set; }

        public void OnGet()
        {



        }

        public void OnPost()
        {
            if (CorrectAnswer == Guess)
            {
                Output = "Lets play guess a new number";
                var rnd = new Random();
                CorrectAnswer = rnd.Next(min, max);
            }
            else if (Guess < CorrectAnswer)
            {
                Output = "Too low";
            }
            else if (Guess > CorrectAnswer)
            {
                Output = "Too high";
            }
        }

    }
}