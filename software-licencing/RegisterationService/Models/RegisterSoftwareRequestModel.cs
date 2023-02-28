using System;
namespace RegisterationService.Models;

public record RegisterSoftwareRequestModel(string CompanyName, string ContactPerson, string Email, string LicenceKey);