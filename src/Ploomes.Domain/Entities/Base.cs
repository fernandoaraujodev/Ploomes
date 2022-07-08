using System.Collections.Generic;
using System;

namespace Ploomes.Domain.Entities
{
    public abstract class Base
    {
        public Guid Id { get; set; }

        internal List<string> _errors;
        public IReadOnlyCollection<string> Errors => _errors;


        public abstract bool Validate();
    }
}