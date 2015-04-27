using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class StringUtils
    {
        public static String getTrunctedTextWithEllipsis(String text, int maxLength)
        {
            if (text.Length > maxLength)
            {
                int length = maxLength - 3;
                if (length < 1)
                    length = 1;
                return String.Concat(text.Substring(0, length), "...");
            }
            return text;
        }
    }
}
