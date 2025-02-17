namespace BookingCar.Api.Domain.Validators;

/// <summary>
/// Собственный валидор корректности добавленного значение в поле с моделью в виде enum. <br />
/// Если добавлено некорректное значение, то будет ошибка валидации.
/// </summary>
public class EnumValidator : ValidationAttribute
{
    private readonly Type _enumType;

    public EnumValidator(Type enumType)
    {
        _enumType = enumType;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return ValidationResult.Success;
        }

        if (!Enum.IsDefined(_enumType, value))
        {
            return new ValidationResult($"Значение '{value}' не является частью коллекции '{_enumType.Name}'.");
        }

        return ValidationResult.Success;
    }
}
