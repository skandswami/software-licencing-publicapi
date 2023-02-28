using System;
using Refit;
using RegisterationService.Models;
namespace RegisterationService;

public interface ISignatureAPI
{
	[Post("/Signature")]
	Task SignSoftware([Body] SignatureRequestModel model);
}

