using System.Collections.Generic;
using System;
using FluentValidation;
using FluentValidation.Results;

namespace Ploomes.Domain.Entities
{
    public abstract class Base
    {
        public long Id { get; set; }

        internal List<string> _errors;
        public IReadOnlyCollection<string> Errors => _errors;

        private void AddErrorList(IList<ValidationFailure> errors)
        {
            foreach (var error in errors)
                _errors.Add(error.ErrorMessage);
        }

        protected bool Validate<T, J>(T validator, J obj)
            where T : AbstractValidator<J>
        {
            var validation = validator.Validate(obj);

            if (validation.Errors.Count > 0)
                AddErrorList(validation.Errors);

            return _errors.Count == 0;
        }
    }
}