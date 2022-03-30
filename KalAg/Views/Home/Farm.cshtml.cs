using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoilNSunshine.Pages
{
    public class FarmModel : PageModel
    {
        private readonly ILogger<FarmModel> _logger;

        public FarmModel(ILogger<FarmModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
