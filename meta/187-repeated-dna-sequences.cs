// 187. Repeated DNA Sequences

/*
 * Completion Time:
 *  Attempt 1: 5 minutes, TC: O(n), SC: O(n), Notes: off-by-one error for end of string, then fixed
 *
*/

public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var foundSeqs = new HashSet<string>();
        var repeatedSeqs = new HashSet<string>();

        if(s.Length < 10) {
            return new string[0];
        }

        for(int i = 0; i <= s.Length - 10; i++) {
            var seq = s.Substring(i, 10);

            if(foundSeqs.Contains(seq)) {
                repeatedSeqs.Add(seq);
            } else {
                foundSeqs.Add(seq);
            }
        }

        return repeatedSeqs.ToArray();
    }
}