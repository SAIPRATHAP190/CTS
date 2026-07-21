using System.ComponentModel.DataAnnotations;

namespace InventoryApi.Validation
{
    public class MinimumPriceAttribute : ValidationAttribute
    {
        private readonly double _minimumPrice;

        public MinimumPriceAttribute(double minimumPrice)
        {
            _minimumPrice = minimumPrice;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is decimal priceValue)
            {
                if ((double)priceValue < _minimumPrice)
                {
                    return new ValidationResult(ErrorMessage ?? $"Price cannot be lower than ${_minimumPrice}");
                }
            }
            return ValidationResult.Success;
        }
    }
}
