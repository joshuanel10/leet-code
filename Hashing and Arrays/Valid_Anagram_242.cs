public class Solution {
    public bool IsAnagram(string s, string t) {
       HashSet<String> set1 = new HashSet<String>();
       HashSet<String> set2 = new HashSet<String>();

       for (int i = 0; i < s.Length; i++){
           set1.Add(Char.ToString(s[i]));
       }
       for (int j = 0; j < s.Length; j++){
           set2.Add(Char.ToString(t[j]));
       }

       if (set1.SetEquals(set2)) {
           return true;
       }
       return false;
    }
}
