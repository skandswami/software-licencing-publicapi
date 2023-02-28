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
        private readonly ISignatureAPI _signatureapi;

        public RegistrationController(ILogger<RegistrationController> logger, ISignatureAPI signatureapi)
		{
			_logger = logger;
            _signatureapi = signatureapi;
        }

		[HttpPost]
		public async Task<IActionResult> SoftwareRegistration(RegisterSoftwareRequestModel model)
		{
			// will throw relevent exemption if not succeeded, no requirement to capture return value from the API.
			await _signatureapi.SignSoftware(new SignatureRequestModel
			(
				model.CompanyName,
				model.ContactPerson,
				model.Email,
				model.LicenceKey
			));

            return Ok();
		}

	}
}

