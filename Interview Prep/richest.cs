public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int top = 0; //Used to store highest acc value.

        //Go through each account
        foreach (var account in accounts) {
            top = Math.Max(top, account.Sum()); //Math.Max will always pick the highest sum of accounts
        }

        return top;
    }
}