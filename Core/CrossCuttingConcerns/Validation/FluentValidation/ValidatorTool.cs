using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using FluentValidation.Results;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValidatorTool
    {
        public static List<ValidationFailure> Errors { get; set; }
        public static void FluentValidate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            Errors = result.Errors;

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }

        public static List<string> GetValidationErrors()
        {
            var propertyNames = Errors.Select(e => e.PropertyName).ToArray();
            var errorMessages = Errors.Select(e => e.ErrorMessage).ToArray();

            var result = new List<string>(Errors.Count);

            for (int i = 0; i < Errors.Count; i++)
            {
                result.Add(propertyNames[i] + " - " + errorMessages[i]);
            }

            return result;
        }
    }
}
