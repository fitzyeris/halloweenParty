using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace halloweenParty.Pages
{
    public class GuestListModel : PageModel
    {
        private readonly ILogger<GuestListModel> _logger;

        public GuestListModel(ILogger<GuestListModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
