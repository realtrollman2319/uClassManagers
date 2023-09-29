using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using uScript.API.Attributes;
using uScript.Core;

namespace uClassManagers.Extras.uRegularExpressions
{
    [ScriptModule("RegEx")]
    public class RegExClass
    {
        [ScriptFunction("escape")]
        public static string Escape(string str)
        {
            return Regex.Escape(str);
        }

        [ScriptFunction("isMatch")]
        public static bool IsMatch(string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }

        [ScriptFunction("replace")]
        public static string Replace(string input, string pattern, string replacement)
        {
            return Regex.Replace(input, pattern, replacement);
        }

        [ScriptFunction("split")]
        public static ExpressionValue Split(string input, string pattern)
        {
            string[] stringList = Regex.Split(input, pattern);
            IEnumerable<ExpressionValue> EVStringList = stringList.Select(b => (ExpressionValue)b);
            return ExpressionValue.Array(EVStringList);
        }

        [ScriptFunction("matches")]
        public static ExpressionValue Matches(string input, string pattern)
        {
            List<ExpressionValue> stringVal = new List<ExpressionValue>();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                stringVal.Add(match.Value);
            }

            return ExpressionValue.Array(stringVal);
        }
    }
}