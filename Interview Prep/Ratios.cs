using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int Count = arr.Count;
        int posCount = 0;
        int minCount = 0;
        int zeroCount = 0;
        string output = "";
        int j = 0;

        for (j = 0; j < Count; j++) {
           if (arr[j] > 0) {
                posCount++;         
           } else if (arr[j] < 0) {
                minCount++;
           } else {
                zeroCount++;
           }
        }

        output = (posCount/Count) + "/n" + (minCount/Count) + "/n" + (zeroCount/Count);
        return output;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
