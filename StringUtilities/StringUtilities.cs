﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StringUtilities
{
    public static class StringUtilities
    {
        public static bool IsUniqueCharacterSet(this string s)
        {
            // remove all space chars from string (clean up)
            var cleanString = Regex.Replace(s, @"\s+", "").ToLower();

            //Console.WriteLine(cleanString);

            // check for duplicate letters
            HashSet<char> hashSet = new HashSet<char>();

            foreach(var letter in cleanString)
            {
                if(hashSet.Contains(letter))
                {
                    return false;
                }

                hashSet.Add(letter);
            }
            return true;
        }
    }
}
