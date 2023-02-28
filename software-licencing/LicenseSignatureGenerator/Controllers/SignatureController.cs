using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LicenseSignatureGenerator.Controllers
{
    public class SignatureController : ControllerBase
    {
        private readonly ILogger<SignatureController> _logger;

        public SignatureController(ILogger<SignatureController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "ActivateSoftware")]
        public IActionResult ActivateSoftware()
        {
            return Ok();
        }
    }
}

