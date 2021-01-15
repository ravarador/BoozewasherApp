using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoozewasherDomain.Entities;
using FluentValidation;

namespace BoozewasherApp.Forms.ItemForms
{
    public class ItemValidator : AbstractValidator<Item>
    {
        public ItemValidator()
        {
            RuleFor(v => v.Name)
                .NotEmpty().When(item => string.IsNullOrWhiteSpace(item.Name));
        }
    }
}
