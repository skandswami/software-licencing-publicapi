using System;
namespace RegisterationService.Models;

public record SignatureRequestModel(string CompanyName, string ContactPerson, string Email, string LicenceKey);
