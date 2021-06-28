using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.AdminUserName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapın");
            RuleFor(x => x.AdminUserName).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Fazla Veri Girişi Yapmayın");
            RuleFor(x => x.AdminPassword).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapın");
            RuleFor(x => x.AdminPassword).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Fazla Veri Girişi Yapmayın");
        }
    }
}
