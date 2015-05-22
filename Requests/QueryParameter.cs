namespace Octosharp.Requests
{
    public class QueryParameter
    {
        private readonly string _name;
        private readonly string _value;

        internal QueryParameter(string name, string value)
        {
            _name = name;
            _value = value;
        }

        internal string Name
        {
            get { return _name; }
        }

        internal string Value
        {
            get { return _value; }
        }
    }
}