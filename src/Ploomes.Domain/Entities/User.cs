using System;
using System.Collections.Generic;
using Ploomes.Domain.Validators;

namespace Ploomes.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        // EF 
        protected User() { }

        public User(string name, string email, string password)
        {
            Id = Guid.NewGuid(); 
            Name = name;
            Email = email;
            Password = password;
            _errors = new List<string>();
        }

        // Métodos
        public void ChangeName(string name)
        {
            Name = name;
            Validate();
        }

        public void ChangePassword(string password)
        {
            Password = password;
            Validate();
        }

        public void ChangeEmail(string email)
        {
            Email = email;
            Validate();
        }

        // Autovalidação
        public override bool Validate()
        {
            var validator = UserValidator();
            var validation = validator.Validate(this);

            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                    _errors.Add(error.Message);

                throw new Exception("Alguns campos estão inválidos, por favor corrija-os!" + _errors[0]);
            }

            return true;
        }

    }
}