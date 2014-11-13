using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AON_coding_test.Models;

namespace StringManipulation
{
    /// <summary>
    /// Represents string function extensions
    /// </summary>
    public static class StrExt {

        /// <summary>
        /// extended function to switch chars from the string
        /// </summary>
        public static string ReplaceAt(this string input, int index, char newChar)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            char[] chars = input.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }

        /// <summary>
        /// extended function to return chars at index
        /// </summary>

        public static char ChartAt(this string input, int index)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            char[] chars = input.ToCharArray();
            var retVal = chars[index];

            return retVal;
            
        }
    }

    /// <summary>
    /// represents service for string manipulation
    /// </summary>
    public class StringManipulationService
    {
        /// <summary>
        /// method that daoes string manipulation. takes in StringModel and returns StringModel 
        /// </summary>
     
        public StringModel CharSwitch(StringModel inputString)
        {
           
            var startChar = inputString.InputString.ChartAt(inputString.StartIndex - 1);
            var endChar = inputString.InputString.ChartAt(inputString.EndIndex - 1);

            var strTmp = inputString.InputString.ReplaceAt(inputString.StartIndex - 1, endChar).ReplaceAt(inputString.EndIndex - 1, startChar);


            var stringObj = new StringModel()
            {
                EndIndex = inputString.StartIndex,
                StartIndex = inputString.StartIndex,
                InputString = strTmp
            };
           

            return stringObj;

        }
    }
}