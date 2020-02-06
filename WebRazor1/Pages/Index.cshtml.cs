using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using WebRazor1.Resources;

namespace WebRazor1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IStringLocalizer _sharedLocalizer1;
        private readonly IStringLocalizer _sharedLocalizer2;

        public IndexModel(ILogger<IndexModel> logger, IStringLocalizerFactory localizerFactory)
        {
            _logger = logger;

            // takto mi to nefunguje ani za svet!!!
            var type = typeof(MyRes);
            _sharedLocalizer1 = localizerFactory.Create(type);

            // toto je jediny sposob, ako mi funguje SharedResource...nazov+assemblyName, assemblyName mozem napisat priamo, alebo zistit cez type
            // dummy class musi mat namespace na Resources
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            //_sharedLocalizer2 = localizerFactory.Create("MyRes", assemblyName.Name);               ;
            _sharedLocalizer2 = localizerFactory.Create("MyRes", "WebRazor1");
        }

        public void OnGet()
        {
            ViewData["Popisok1"] = _sharedLocalizer1["Testing"];
            ViewData["Popisok2"] = _sharedLocalizer2["Testing"];
        }
    }
}
