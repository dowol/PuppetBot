using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System;

public static class StringExtensions
{
    private static char[] whitespaces = new[]{ '\0', ' ', '\t', '\n', '\v', '\f', '\r',  '\xa0', '\u3000' };

    public static string Capitalize(this string str)
    {
        string[] words = str.Split(whitespaces, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        for(int i = 0; i < words.Length; i++)
            words[i] = words[i][0..0].ToUpperInvariant() + words[i][1..].ToLowerInvariant();
        
        return string.Join(' ', words);
    }

    
}
