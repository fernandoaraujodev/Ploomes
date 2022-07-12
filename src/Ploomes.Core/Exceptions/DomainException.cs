using System;
using System.Collections.Generic;

namespace Ploomes.Core.Exceptions
{
    public class DomainException : Exception
    {
        // Recebe a lista de erros
        internal List<string> _errors;

        public IReadOnlyCollection<string> Errors => _errors;

        public DomainException() {}

        // Passa a lista para uma exceção especializada
        public DomainException(string message, List<string> errors) : base(message)
        {
            _errors = errors;
        }

        public DomainException(string message) : base(message) { }

        public DomainException(string message, Exception innerException) : base(message, innerException) { }

    }
}
