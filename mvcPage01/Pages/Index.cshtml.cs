using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SayHello;

namespace mvcPage01.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IEmpRepository empRepository;

        public string message { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IEmpRepository empRepository)
        {
            _logger = logger;
            this.empRepository = empRepository;
        }

        public void OnGet()
        {
            message = empRepository.sayHello();
        }
    }
}
