using System;
using FluentValidation;

namespace RegisterationService.Models;

public record RegisterSoftwareRequestModel(string CompanyName, string ContactPerson, string Email, string LicenceKey);

public class RegisterSoftwareRequestModelValidator : AbstractValidator<RegisterSoftwareRequestModel>
{
    public RegisterSoftwareRequestModelValidator()
    {
        RuleFor(m => m.Email).EmailAddress().When(x => x.Email is not null);
    }
}