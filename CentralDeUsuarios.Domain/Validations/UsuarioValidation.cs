using CentralDeUsuarios.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeUsuarios.Domain.Validations
{
    public class UsuarioValidation : AbstractValidator<Usuario>
    {
        public UsuarioValidation()
        {
            RuleFor(u => u.Id)
                .NotEmpty()
                .WithMessage("Id é obrigatório.");
            RuleFor(u => u.Nome)
                .NotEmpty()
                .Length(6, 150)
                .WithMessage("Nome de Usuário inválido.");
            RuleFor(u => u.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Endereço de Email inválido.");
            RuleFor(u => u.Senha)
                .NotEmpty()
                .Length(8, 20)
                    .WithMessage("Senha deve ter de 8 a 20 caracteres.")
                .Matches(@"[A-Z]+")
                    .WithMessage("Senha deve ter pelo menos 1 letra maiúscula")
                .Matches(@"[a-z]+")
                    .WithMessage("Senha deve ter pelo menos 1 letra minúscula")
                .Matches(@"[\!\?\*\.\@]+")
                    .WithMessage("\"Senha deve ter pelo menos 1 caractere especial (!?*.@)");
        }
    }
}
