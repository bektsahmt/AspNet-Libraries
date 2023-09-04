using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidators
{
	public class CustomerValidator:AbstractValidator<Customer>
	{
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz.";
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş olamaz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-mail alanı boş olamaz").EmailAddress().WithMessage("Lütfen Geçerli Bir E-mail Adresi Giriniz.");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş Alanı Boş Olamaz!").InclusiveBetween(18, 60).WithMessage("Yaşınız 18'den büyük 60'dan da küçük olmalıdır.");
            RuleFor(x => x.Birthday).NotEmpty().WithMessage(NotEmptyMessage).Must(x =>
            {
                //return DateTime.Now.AddYears(-18) =>x;
            });
        }
    }
}
