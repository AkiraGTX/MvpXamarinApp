

namespace MvpApp.Core
{
    public class ViewParameter
    {
        public string ParameterName { get; private set; }
        public string Value { get; private set; }

        public ViewParameter(string parameterName, string value)
        {
            this.ParameterName = parameterName;
            this.Value = value;
        }
    }
}