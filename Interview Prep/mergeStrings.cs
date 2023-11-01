public class Solution {
    public string MergeAlternately(string word1, string word2) {

        string mixed = "";

        for (i = 0; i < word1.Length; i++) {
            if (word1[i] = " ") {
                continue;
            } else {
                mixed = mixed + word1[i];
            }
            for (j = 0; j < word2.Length; j++) {
                if (word2[j] = " "){
                    continue;
                } else {
                    mixed = mixed + word2[j];
                }
            }
        }
    }
}