using System.ComponentModel.DataAnnotations;

namespace uh_sample.Validations
{
    /// <summary>Custom validation attribute for valid future date</summary>
    public class ValidFutureDate : ValidationAttribute
    {
        private const string DefaultErrorMessage = "Datetime can not be less than the current date.";

        /// <summary>
        /// Returns whether the input value is valid
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime _dateTime = Convert.ToDateTime(value);
            if (_dateTime > DateTime.UtcNow)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage ?? DefaultErrorMessage);
        }
    }

    /// <summary>
    /// Custom validation attribute to determine if the Event Status Id is Valid.
    /// </summary>
    public class ValidStatus : ValidationAttribute
    {
        private const string DefaultErrorMessage = "Status Id is invalid.";

        /// <summary>
        /// Returns whether the input event status Id is valid
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validStatuses = new int[] { 1, 2, 3, 4 };
            var status = (int)value;
            if (validStatuses.Contains(status))
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage ?? DefaultErrorMessage);
        }
    }
}