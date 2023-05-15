using FluentValidation;

namespace ASC.Domain.Sprockets
{
    internal class SprocketValidator : AbstractValidator<Sprocket>
    {
        public SprocketValidator()
        {
            RuleFor(x => x.Id).NotEqual(Guid.Empty);
            RuleFor(x => x.Name).NotEmpty().NotNull().MinimumLength(8);
            RuleFor(x => x.TeethCount).GreaterThanOrEqualTo(9);
            RuleFor(x => x.ChainPitch).IsInEnum();
        }
    }
}
