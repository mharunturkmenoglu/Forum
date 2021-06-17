using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazarın Hakkında Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Lütfen 50 Karakterden Fazla Veri Girişi Yapmayın");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapın");
            RuleFor(x => x.WriterTitle).NotNull().WithMessage("Ünvanı Boş Geçemezsiniz");
        }
    }
}
