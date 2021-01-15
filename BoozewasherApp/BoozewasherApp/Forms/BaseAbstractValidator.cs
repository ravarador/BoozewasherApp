using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherApp.Forms
{
    public class BaseAbstractValidator<T> : AbstractValidator<T>
        where T : class
    {
        public ValidationResult ValidationResult { get; protected set; }
    }
}
