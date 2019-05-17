public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> ints = new Dictionary<int, int>();
        List<int> intersection = new List<int>();
        
        for(int i = 0; i < nums1.Length; i++) {
            // increasing the count of the key
            if(ints.ContainsKey(nums1[i])){
                ints[nums1[i]]++;
                continue;
            }
            
            // adding new int to our dictionary
            ints.Add(nums1[i], 1);
        }
        
        for(int i = 0; i < nums2.Length; i++) {
            if(ints.ContainsKey(nums2[i]) && ints[nums2[i]] > 0) {
                intersection.Add(nums2[i]);
                ints[nums2[i]]--;
            }
        }
        
        return intersection.ToArray();
    }
}
