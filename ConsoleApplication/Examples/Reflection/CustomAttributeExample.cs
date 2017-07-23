using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Examples.Reflection
{
    internal class CustomAttributeExample : Example
    {
        public override void Run()
        {
            var type = typeof(CustomClass);

            WriteClassCustomAttriubtes(type);

            WriteClassMethodsCustomAttributes(type);
        }

        private void WriteClassMethodsCustomAttributes(Type type)
        {
            foreach (var method in type.GetMethods())
                WriteCustomAttributes(method.GetCustomAttributes(typeof(CustomAttriubte), inherit: false));
        }

        private void WriteClassCustomAttriubtes(Type type)
        {
            var customAttributes = type.GetCustomAttributes(typeof(CustomAttriubte), inherit: false);

            WriteCustomAttributes(customAttributes);
        }

        private void WriteCustomAttributes(object[] attributes)
        {
            foreach (CustomAttriubte customAttribute in attributes)
                Host.WriteLine(customAttribute.Description);
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    internal class CustomAttriubte : Attribute
    {
        public CustomAttriubte(string description)
        {
            Description = description;
        }

        public string Description { get; private set; }
    }

    [CustomAttriubte("Class")]
    internal class CustomClass
    {
        [CustomAttriubte("Method")]
        public void CustomMethod()
        {

        }
    }
}
