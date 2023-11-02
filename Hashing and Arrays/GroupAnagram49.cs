public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        if (strs.Length == 0) {
            return new List<IList<string>>(); //Will return empty list
        }

         Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>(); //Char count to list of anagrams

         foreach (string str in strs) {
             string sortedStr = CountSort(str); //Will sort each letter with its index
             if (!anagrams.ContainsKey(sortedStr)) {
                 anagrams.Add(sortedStr, new List<string>());
             }

            anagrams[sortedStr].Add(str);
         }

         IList<IList<string>> result = new List<IList<string>>();
         foreach (KeyValuePair<string, List<string>> kvp in anagrams) {
             result.Add(kvp.Value);
         }
         return result;
            
    }

    private string CountSort(string s) {
        int[] counts = new int[26];
        foreach (char c in s) {
            counts[c - 'a'] += 1;
        }

        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < counts.Length; i++){
            if (counts[i] > 0) {
                builder.Append((char)('a' + i), counts[i]);
            }
        }

        return builder.ToString();
    }



}
