using System;

namespace Octosharp.Helpers
{
    internal class RequestValue : Attribute
    {
        private readonly string _value;

        public RequestValue(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }
    }

    internal static class GetRequestValueAttribute
    {
        internal static string GetStringValue(this Enum value)
        {
            string output = null;
            var type = value.GetType();
            var field = type.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof (RequestValue), false) as RequestValue[];
            if (attributes != null && attributes.Length > 0)
            {
                output = attributes[0].Value;
            }
            return output;
        }
    }
}