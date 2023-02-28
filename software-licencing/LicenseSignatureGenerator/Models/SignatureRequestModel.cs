using System;
namespace LicenseSignatureGenerator.Models;

public record SignatureRequestModel(string CompanyName, string ContactPerson, string Email, string LicenceKey);

