using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace LMS.Application.Helpers;
public class Utils
{
    public static Guid CreateGuid()
    {
        return Guid.NewGuid();
    }

    public static string GetEnumDisplayName<TEnum>(TEnum value) where TEnum : Enum
    {
        var enumType = typeof(TEnum);
        var enumName = Enum.GetName(enumType, value);

        if (enumName == null)
        {
            return value.ToString();
        }

        var member = enumType.GetMember(enumName).FirstOrDefault();
        var displayAttribute = member?.GetCustomAttribute<DisplayAttribute>();

        return displayAttribute?.Name ?? enumName;
    }
}
