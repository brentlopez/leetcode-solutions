// 1614. Maximum Nesting Depth of the Parentheses
/*
 * Completion Time:
 *  Attempt 1: 4 minutes, TC: O(n), SC: O(1)
 *
*/


public class Solution
{
    public int MaxDepth(string s)
    {
        var maxDepth = 0;
        var currentDepth = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals('('))
            {
                currentDepth++;
            }

            if (s[i].Equals(')'))
            {
                currentDepth--;
            }

            maxDepth = Math.Max(maxDepth, currentDepth);
        }

        return maxDepth;
    }
}