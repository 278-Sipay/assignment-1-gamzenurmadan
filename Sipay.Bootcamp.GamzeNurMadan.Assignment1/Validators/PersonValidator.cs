using FluentValidation;
using Sipay.Bootcamp.GamzeNurMadan.Assignment1.Models;

namespace Sipay.Bootcamp.GamzeNurMadan.Assignment1.Validators
{
    public class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(person => person.Name).NotEmpty().WithMessage("{PropertyName} is required.").Length(5, 100).WithMessage(
                "{PropertyName}'s length should be minimum 5 and maximum 100.");
            RuleFor(person => person.Lastname).NotEmpty().WithMessage("{PropertyName} is required.").Length(5, 100).WithMessage(
                "{PropertyName}'s length should be minimum 5 and maximum 100.");
            RuleFor(person => person.Phone).NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(person => person.AccessLevel).NotEmpty().WithMessage("{PropertyName} is required.").InclusiveBetween(1, 5).WithMessage(
                "{PropertyName} should be at least {From} or {To} at most.");
            RuleFor(person => person.Salary).NotEmpty().WithMessage("{PropertyName} is required.").InclusiveBetween(5000, 50000).WithMessage(
                "{PropertyName} should be at least {From} or {To} at most.");
        }
    }
}
