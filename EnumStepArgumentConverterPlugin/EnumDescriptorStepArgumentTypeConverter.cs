using System.ComponentModel;
using System.Globalization;
using TechTalk.SpecFlow.Bindings;
using TechTalk.SpecFlow.Bindings.Reflection;

namespace EnumDescriptionStepArgumentTransformer1
{
    internal class EnumDescriptorStepArgumentTypeConverter : IStepArgumentTypeConverter
    {
        public bool CanConvert(object value, IBindingType typeToConvertTo, CultureInfo cultureInfo)
        {
            if (typeToConvertTo is RuntimeBindingType t && t.Type.IsEnum && value is string)
            {
                foreach (var field in t.Type.GetFields())
                {
                    if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute)
                        return true;
                }
            }
            return false;
        }

        public object Convert(object value, IBindingType typeToConvertTo, CultureInfo cultureInfo)
        {
            var t = typeToConvertTo as RuntimeBindingType;
            var description = value as string;

            foreach (var field in t.Type.GetFields())
            {
                if ((Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute) && attribute.Description == description)
                {
                    return field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return field.GetValue(null);
                }
            }

            throw new ArgumentException($"{description} Not found.", nameof(value));
        }
    }
}