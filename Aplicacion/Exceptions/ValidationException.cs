using FluentValidation.Results;

namespace Aplicacion.Exceptions
{
    public class ValidationException : Exception
    {
        public List<string> Errors { get; }
        
        public ValidationException() : base("Se han generado uno o mas errores de validaion")
        {
            Errors = new List<string>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach(var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }

    }
}