using FluentValidation;
using Hurghada.Core.Features.Properties.Commands.Models;
using Hurghada.Service.Abstracts;

namespace Hurghada.Core.Features.Properties.Commands.Validators
{
    public class AddPropertyValidator : AbstractValidator<AddPropertyCommand>
    {
        #region feilds
        private readonly IPropertyService _propertyService;
        #endregion
        #region Constructors
        public AddPropertyValidator(IPropertyService propertyService)
        {
            _propertyService = propertyService;
            ApplyCustomValidations();
            ApplyValidationsRules();
        }
        #endregion
        #region Methods
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address is required");
            RuleFor(x => x.DownPayment).NotEmpty().WithMessage("DownPayment is required");
            RuleFor(x => x.MonthlyPayment).NotEmpty().WithMessage("MonthlyPayment is required");
            RuleFor(x => x.DailyPayment).NotEmpty().WithMessage("DailyPayment is required");
            RuleFor(x => x.BedRooms).NotEmpty().WithMessage("BedRooms is required");
            RuleFor(x => x.PathRooms).NotEmpty().WithMessage("PathRooms is required");
            RuleFor(x => x.Area).NotEmpty().WithMessage("Area is required");
            RuleFor(x => x.Floor).NotEmpty().WithMessage("Floor is required");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("ImageUrl is required");

        }
        public void ApplyCustomValidations()
        {
            RuleFor(x => x.Title)
                .MustAsync(async (title, cancellation) => await _propertyService.IsTitleExist(title) == false)
                .WithMessage("Title is already exist");
        }
        #endregion
    }
}
