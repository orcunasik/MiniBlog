using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MiniBlog.Business.Helpers
{
    public static class SubstringForBlogHelper
    {
        public static string CharacterDelimiter(this string text, int length)
        {
            if (text.Length > length)
            {
                return text.Substring(0, length) + "...";
            }
            else
            {
                return text;
            }
        }
    }
}
