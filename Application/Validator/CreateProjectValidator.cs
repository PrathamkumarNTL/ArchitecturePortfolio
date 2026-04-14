using Application.DTOs.Projects;
using FluentValidation;

namespace Application.Validator
{
    public class CreateProjectValidator : AbstractValidator<CreateProjectDto>
    {
        public CreateProjectValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Category).NotEmpty();
            RuleFor(x => x.Location).NotEmpty();
            RuleFor(x => x.CompletetionDate).LessThanOrEqualTo(DateTime.Now);
        }
    }
}
