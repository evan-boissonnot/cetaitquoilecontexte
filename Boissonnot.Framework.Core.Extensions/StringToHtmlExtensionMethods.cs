using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Boissonnot.Framework.Core.Extensions
{
    public static class StringToHtmlExtensionMethods
    {
        #region Public methods
        /// <summary>
        /// Transforme un texte en url
        /// </summary>
        /// <returns></returns>
        public static string ToUrl(this string content, int maxLength = 255)
        {
            var normalizedString = content.ToLowerInvariant().Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();
            var stringLength = normalizedString.Length;
            var prevdash = false;
            var trueLength = 0;
            char c;

            for (int i = 0; i < maxLength; i++)
            {
                c = normalizedString[i];
                switch (CharUnicodeInfo.GetUnicodeCategory(c))
                {
                    case UnicodeCategory.LowercaseLetter:
                    case UnicodeCategory.UppercaseLetter:
                    case UnicodeCategory.DecimalDigitNumber:
                        if (c < 128)
                            stringBuilder.Append(c);
                        else
                            stringBuilder.Append(c.RemapInternationalCharToAscii());
                        prevdash = false;
                        trueLength = stringBuilder.Length;
                        break;
                    case UnicodeCategory.SpaceSeparator:
                    case UnicodeCategory.ConnectorPunctuation:
                    case UnicodeCategory.DashPunctuation:
                    case UnicodeCategory.OtherPunctuation:
                    case UnicodeCategory.MathSymbol:
                        if (!prevdash)
                        {
                            stringBuilder.Append('-');
                            prevdash = true;
                            trueLength = stringBuilder.Length;
                        }
                        break;
                }
                if (maxLength > 0 && trueLength >= maxLength)
                    break;
            }

            var result = stringBuilder.ToString().Trim('-');
            return maxLength <= 0 || result.Length <= maxLength ? result : result.Substring(0, maxLength);
        }

        /// <summary>
        /// Transforme certains caractères en lettre invariant
        /// </summary>
        /// <returns></returns>
        public static string RemapInternationalCharToAscii(this char c)
        {
            string result = string.Empty;
            string s = c.ToString().ToLowerInvariant();

            if ("àåáâäãåą".Contains(s))
                result = "a";
            else if ("èéêëę".Contains(s))
                result = "e";
            else if ("ìíîïı".Contains(s))
                result = "i";
            else if ("òóôõöøőð".Contains(s))
                result = "o";
            else if ("ùúûüŭů".Contains(s))
                result = "u";
            else if ("çćčĉ".Contains(s))
                result = "c";
            else if ("żźž".Contains(s))
                result = "z";
            else if ("śşšŝ".Contains(s))
                result = "s";
            else if ("ñń".Contains(s))
                result = "n";
            else if ("ýÿ".Contains(s))
                result = "y";
            else if ("ğĝ".Contains(s))
                result = "g";
            else if (c == 'ř')
                result = "r";
            else if (c == 'ł')
                result = "l";
            else if (c == 'đ')
                result = "d";
            else if (c == 'ß')
                result = "ss";
            else if (c == 'þ')
                result = "th";
            else if (c == 'ĥ')
                result = "h";
            else if (c == 'ĵ')
                result = "j";

            return result;
        }
    }
    #endregion
}
