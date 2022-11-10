using BoDi;
using System.ComponentModel;
using System.Globalization;
using TechTalk.SpecFlow.Bindings;
using TechTalk.SpecFlow.Bindings.Reflection;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.Tracing;

namespace EnumDescriptionStepArgumentTransformer1
{
    public class EnumDescriptorStepArgumentTypeConverter : IStepArgumentTypeConverter
    {
        private StepArgumentTypeConverter _baseConverter;

        public EnumDescriptorStepArgumentTypeConverter(ITestTracer testTracer, IBindingRegistry bindingRegistry, IContextManager contextManager, IBindingInvoker bindingInvoker)
        {
            _baseConverter = new StepArgumentTypeConverter(testTracer, bindingRegistry, contextManager, bindingInvoker);
        }

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
            return _baseConverter.CanConvert(value, typeToConvertTo, cultureInfo);
        }

        public object Convert(object value, IBindingType typeToConvertTo, CultureInfo cultureInfo)
        {
            if (typeToConvertTo is RuntimeBindingType t && t.Type.IsEnum && value is string)
            {
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
            return _baseConverter.Convert(value, typeToConvertTo, cultureInfo);
        }
    }
}