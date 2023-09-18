using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCheckLibrary
{
    public class StringCheck
    {
        /// <summary>
        /// Проверка stringName на наличие символов: русские буквы, пробел и дефис
        /// Строка stringName не должна превышать 50 сиволов
        /// </summary>
        /// <param name="stringName"></param>
        /// <returns></returns>
        public bool CheckName(string stringName)
        {
            string regex = @"^((а-я)|(\s)|(\-))+$";
            string regexWhiteSpace = @"^((\s)|(\-))+$";
            if (Regex.Match(stringName, regexWhiteSpace, RegexOptions.IgnoreCase).Success)
            {
                return false;
            }
            else
            {
                if (Regex.Match(stringName, regex, RegexOptions.IgnoreCase).Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
