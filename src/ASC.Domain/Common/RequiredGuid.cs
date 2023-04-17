using System.ComponentModel.DataAnnotations;

namespace ASC.Domain.Common
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredGuid : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is Guid guid && guid == Guid.Empty)
            {
                return false;
            }

            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} may not be an empty Guid.";
        }
    }
}
