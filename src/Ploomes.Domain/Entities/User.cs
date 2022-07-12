using System;
using System.Collections.Generic;
using Ploomes.Core.Exceptions;
using Ploomes.Domain.Validators;

namespace Ploomes.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        // EF 
        protected User(){}

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            _errors = new List<string>();

            Validate();
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
        public bool Validate() => base.Validate(new UserValidator(), this);

    }
}