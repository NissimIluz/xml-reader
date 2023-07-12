using System.Collections.Generic;
using System.Reflection;

namespace AdmonisTest.Constants
{
    public class Halper
    {
        public static void Init<T>(ref T obj, Dictionary<string, string> defaultsValues)
        {
            if (defaultsValues != null)
            {
                foreach (var defaultValue in defaultsValues)
                {
                    PropertyInfo prop = obj.GetType().GetProperty(defaultValue.Key, BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        prop.SetValue(obj, defaultValue.Value, null);
                    }
                }
            }
        }
    }
}
