using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using WebRazor1.Resources;

namespace WebRazor1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IStringLocalizer<PrivacyModel> _stringLocalizer;
        private readonly IStringLocalizer _sharedLocalizer1;
        private readonly IStringLocalizer _sharedLocalizer2;
        //private readonly IStringLocalizer<SharedResource> _sharedLocalizer2;

        public PrivacyModel(ILogger<PrivacyModel> logger, IStringLocalizer<PrivacyModel> stringLocalizer, IStringLocalizerFactory localizerFactory)
        {
            _logger = logger;
            _stringLocalizer = stringLocalizer;

            // toto je jediny sposob, ako mi funguje SharedResource
            _sharedLocalizer1 = localizerFactory.Create("SharedResource", "WebRazor1");
            // cez type stale nula bodov
            _sharedLocalizer2 = localizerFactory.Create(typeof(SharedResource));
        }

        public void OnGet()
        {
            ViewData["Title"] = _stringLocalizer["Privacy Policy"];
            ViewData["Header"] = _stringLocalizer["Use this page to detail your site's privacy policy."];
            ViewData["Popisok1"] = _sharedLocalizer1["Info1"];

            ViewData["Popisok1"] = _sharedLocalizer2["Info2"];
        }
    }
}
