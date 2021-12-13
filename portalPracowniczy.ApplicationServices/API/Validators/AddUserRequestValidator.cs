using FluentValidation;
using portalPracowniczy.ApplicationServices.API.Domain;

namespace portalPracowniczy.ApplicationServices.API.Validators
{
    public class AddUserRequestValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserRequestValidator()
        {
            this.RuleFor(x => x.Name).NotEmpty();
            this.RuleFor(x => x.Login).NotEmpty();
        }
    }
}
