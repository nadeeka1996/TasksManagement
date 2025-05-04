using FluentValidation.Results;
using TasksManagement.Application.Validators;

namespace TasksManagement.Application.Models.Requests.Auth;

public record RegisterRequest(
    string Name,
    string Email,
    string Password
)
{
    public ValidationResult Validate()
    {
        return new RegisterRequestValidator().Validate(this);
    }
}
