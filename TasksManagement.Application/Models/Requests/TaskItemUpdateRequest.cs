using FluentValidation.Results;
using TasksManagement.Domain.Enums;
using TasksManagement.Application.Validators;

namespace TasksManagement.Application.Models.Requests;

public record TaskItemUpdateRequest(
    string Title,
    string Description,
    TaskItemStatus Status
)
{
    public ValidationResult Validate()
    {
        return new TaskItemUpdateRequestValidator().Validate(this);
    }
}
