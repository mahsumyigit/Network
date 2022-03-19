using FluentValidation;
using network;

public class TeamValidators : AbstractValidator<Team>
{
    public TeamValidators()
    {
        RuleFor(x => x.Name).NotNull().WithMessage("Email formati hatalıdır");

    }
}