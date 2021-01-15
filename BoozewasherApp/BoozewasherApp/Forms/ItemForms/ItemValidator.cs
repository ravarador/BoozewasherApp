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
            RuleFor(v => v.Name).NotEmpty();
            RuleFor(v => v.Description).NotEmpty();
            RuleFor(v => v.Barcode).NotEmpty();
        }
    }
}
