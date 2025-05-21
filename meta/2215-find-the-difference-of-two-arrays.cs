// 2215. Find the Difference of Two Arrays
/*
 * Completion Time:
 *  Attempt 1: 8 minutes, TC: O(n+m), SC:O(n+m)
 *
*/

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var nums1HashSet = new HashSet<int>();
        var nums2HashSet = new HashSet<int>();
        var commonNums = new HashSet<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            nums1HashSet.Add(nums1[i]);
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            var num = nums2[i];

            if (!nums1HashSet.Contains(num))
            {
                nums1HashSet.Remove(num);
                commonNums.Add(num);
            }
            else if (!commonNums.Contains(num))
            {
                nums2HashSet.Add(num);
            }
        }

        return new int[][] { nums1HashSet.ToArray(), nums2HashSet.ToArray() };
    }
}