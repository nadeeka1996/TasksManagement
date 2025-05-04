using FluentValidation.Results;
using TasksManagement.Application.Validators;

namespace TasksManagement.Application.Models.Requests.Auth;

public record LoginRequest(
    string Email,
    string Password
)
{
    public ValidationResult Validate()
    {
        return new LoginRequestValidator().Validate(this);
    }
}
