using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BroccoliData;

namespace PickleWebsite.Pages
{
    public class PicklesPageModel : PageModel
    {
		public readonly BroccoliDataHolder broccolis;
		private readonly ILogger<PicklesPageModel> _logger;

        public PicklesPageModel(ILogger<PicklesPageModel> logger)
        {
            _logger = logger;
			broccolis = new BroccoliDataHolder();
		}

        public void OnGet()
        {
        }
    }
}
