using BoozewasherDomain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Forms.VehicleForms
{
    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(v => v.Type).NotEmpty();
            RuleFor(v => v.Brand).NotEmpty();
            RuleFor(v => v.Model).NotEmpty();
            RuleFor(v => v.Description).NotEmpty();
        }
    }
}
