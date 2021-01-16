using BoozewasherDomain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Forms.TransactionForms
{
    public class TransactionValidator : AbstractValidator<Transaction>
    {
        public TransactionValidator()
        {
            RuleFor(v => v.PlateNumber).NotEmpty();
            RuleFor(v => v.ServiceId).NotEmpty();
            RuleFor(v => v.VehicleId).NotEmpty();
            RuleFor(v => v.Cost).NotEmpty();
        }
    }
}
