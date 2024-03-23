using FluentValidation;
using HotelierProject.Application.Features.Commands.StaffCommand.CreateStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Validators.Staffs
{
    public class CreateStaffValidator:AbstractValidator<CreateStaffCommandRequest>
    {
        public CreateStaffValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please, enter staff name.")
                .Length(3, 25)
                .WithMessage("Please enter the staff name between 3 and 25 characters.");

            RuleFor(s => s.Profeesion)
                .NotNull()
                .NotEmpty()
                .WithMessage("Please, enter staff profession")
                .Length(3,25)
                .WithMessage("Please enter the staff profession between 3 and 25 characters.");

            RuleFor(s => s.FaceBookUrl)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please, enter staff's Facebook Url")
                .Length(5,100)
                .WithMessage("Please enter the staff's Facebook url between 10 and 100 characters.");


            RuleFor(s => s.InstagramUrl)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please, enter staff's Instagram Url")
                .Length(5, 100)
                .WithMessage("Please enter the staff's Instagram Url between 10 and 100 characters.");

            RuleFor(s => s.TwitterUrl)
               .NotEmpty()
               .NotNull()
               .WithMessage("Please, enter staff's Twitter Url")
               .Length(5, 100)
               .WithMessage("Please enter the staff's Twitter Url between 10 and 100 characters.");
        }
    }
}
