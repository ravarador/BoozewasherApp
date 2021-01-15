using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoozewasherDomain.Entities;
using FluentValidation;

namespace BoozewasherApp.Forms.ItemForms
{
    public class ItemValidator : BaseAbstractValidator<Item>
    {
        public ItemValidator(Item item)
        {
            RuleFor(v => v.Name)
                .NotEmpty().When(m => string.IsNullOrWhiteSpace(m.Name))
                .WithMessage("Name cannot be blank or whitespace!");

            ValidationResult = Validate(item);
        }
    }
}
