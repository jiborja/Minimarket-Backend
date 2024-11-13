

using FluentValidation;

namespace Aplicacion.Feature.Inventario.Categorias.Commands.CreateCategoria
{
    public class CreateClienteCommandValidator : AbstractValidator<CreateCategoriaCommand>
    {
        public CreateClienteCommandValidator()
        {
            RuleFor(p=>p.Nombre)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength}");
            RuleFor(p=>p.Descripcion)
                .MaximumLength(250).WithMessage("{PropertyName} no debe exceder de {MaxLength}");
        }
    }
}