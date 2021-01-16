using BoozewasherDomain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Forms.ServiceForms
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(v => v.Type).NotEmpty();
            RuleFor(v => v.Description).NotEmpty();
        }
    }
}
