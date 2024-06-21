using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp3.Components
{
    public class NullableInputDate<T> : InputDate<T>
    {
        protected override bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
        {
            if (string.IsNullOrEmpty(value))
            {
                result = default;
                validationErrorMessage = null;
                return true;
            }

            return base.TryParseValueFromString(value, out result, out validationErrorMessage);
        }
    }
}
