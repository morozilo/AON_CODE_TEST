using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AON_coding_test.Models;

namespace StringManipulation
{
     public class StringManipulation
    {
        static public StringModel charSwitch(StringModel inputString)
        {
            string returnString = inputString.inputSring;
            List<char> charList = returnString.ToList();
            char endChar = charList[inputString.endIndex+1];
            charList[inputString.endIndex+1] = charList[inputString.startIndex+1];
            charList[inputString.startIndex+1] = endChar;

            StringModel stringObj = new StringModel();
            stringObj.inputSring = charList.ToString();
            stringObj.startIndex = inputString.startIndex;
            stringObj.endIndex = inputString.endIndex;

            return stringObj;
        }
    }
}