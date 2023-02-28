using System;
using Microsoft.AspNetCore.Mvc;
using RegisterationService.Models;

namespace RegisterationService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RegistrationController : ControllerBase
	{
        private readonly ILogger<RegistrationController> _logger;

        public RegistrationController(ILogger<RegistrationController> logger)
		{
			_logger = logger;
		}

		[HttpPost]
		public async Task<IActionResult> SoftwareRegistration(RegisterSoftwareRequestModel model)
		{
			return Ok();

		}

	}
}

