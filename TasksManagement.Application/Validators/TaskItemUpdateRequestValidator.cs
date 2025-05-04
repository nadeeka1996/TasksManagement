using FluentValidation;
using TasksManagement.Application.Models.Requests;
using TasksManagement.Domain.Enums;

namespace TasksManagement.Application.Validators;

public class TaskItemUpdateRequestValidator : AbstractValidator<TaskItemUpdateRequest>
{
    public TaskItemUpdateRequestValidator()
    {
        RuleFor(request => request.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(200).WithMessage("Title must not exceed 200 characters.");

        RuleFor(request => request.Status)
            .IsInEnum().WithMessage("Provided Status is not valid.");
    }
}
