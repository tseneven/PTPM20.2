using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PTPM20._2wf
{
    static public class Validation
    {
        static public string CheckTextFieldOfText(string text)
        {
            if (text is string)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsLetter(text[i]))
                    {
                        continue;
                    }
                    else return $"Ошибка. В данной строке есть цифры: {text}";
                }
                return "";
            }
            else return $"Ошибка. Данная строка не является текстом: {text}";
        }

        static public string CheckTextFieldOfNumeric(string numeric)
        {
            for (int i = 0; i < numeric.Length; i++)
            {
                if (char.IsLetter(numeric[i]))
                {
                    continue;
                }
                else return $"Ошибка. Данная строка не является числом: {numeric}";
            }
            return "";        
        }
    }
}
