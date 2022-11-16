using BoDi;
using System.ComponentModel;
using System.Globalization;
using TechTalk.SpecFlow.Bindings;
using TechTalk.SpecFlow.Bindings.Reflection;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Tracing;
using System.Linq;

namespace EnumDescriptionStepArgumentTransformer1
{
    public class EnumDescriptorStepArgumentTypeConverter : IStepArgumentTypeConverter
    {
        private StepArgumentTypeConverter _baseConverter;

        public EnumDescriptorStepArgumentTypeConverter(ITestTracer testTracer, IBindingRegistry bindingRegistry, IContextManager contextManager, IAsyncBindingInvoker bindingInvoker)
        {
            _baseConverter = new StepArgumentTypeConverter(testTracer, bindingRegistry, contextManager, bindingInvoker);
        }

        public bool CanConvert(object value, IBindingType typeToConvertTo, CultureInfo cultureInfo)
        {
            if (typeToConvertTo is RuntimeBindingType t && t.Type.IsEnum && value is string && DoesEnumUseDescriptionCustomAttribute(t.Type))
            {
                try
                {
                    _ =  ConvertEnumWithDescription(value, typeToConvertTo, cultureInfo);    
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }

            // The target type is either not an Enum or the Enum doens't use the custom Description attribute, therefore fall back to built-in behavior.
            return _baseConverter.CanConvert(value, typeToConvertTo, cultureInfo);
        }

        public async Task<object> ConvertAsync(object value, IBindingType typeToConvertTo, CultureInfo cultureInfo)
        {
            if (typeToConvertTo is RuntimeBindingType t && t.Type.IsEnum && value is string && DoesEnumUseDescriptionCustomAttribute(t.Type))
            {
                return ConvertEnumWithDescription(value, typeToConvertTo, cultureInfo);
            }

            return await _baseConverter.ConvertAsync(value, typeToConvertTo, cultureInfo);
        }

        private object ConvertEnumWithDescription(object value, IBindingType typeToConvertTo, CultureInfo cultureInfo)
        {
            var description = value as string;
            var t = typeToConvertTo as RuntimeBindingType;

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

        private bool DoesEnumUseDescriptionCustomAttribute(Type e)
        {
            return (from field in e.GetFields()
                     from attrs in field.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    select new { })
                    .Any();
        }
    }
}