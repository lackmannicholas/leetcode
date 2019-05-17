public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] merged = mergeArrays(nums1, nums2);
        return getMedian(merged);
    }
    
    private int[] mergeArrays(int[] nums1, int[] nums2) {
        int current1 = 0;
        int current2 = 0;
        int index = 0;
        int[] merged = new int[nums1.Length + nums2.Length];
        
        while(current1 < nums1.Length && current2 < nums2.Length){
            if(nums1[current1] < nums2[current2]){
                merged[index] = nums1[current1++];
            }
            else {
                merged[index] = nums2[current2++];
            }
            
            index++;
        }
        
        // check if both current1 and current2 are at the end, if not, then add the rest
        if(current1 < nums1.Length){
            while(current1 < nums1.Length){
                merged[index] = nums1[current1];
                current1++;
                
                index++;
            }
        }
        else if(current2 < nums2.Length){
            while(current2 < nums2.Length){
                merged[index] = nums2[current2];
                current2++;
                
                index++;
            }
        }
        
        if(index != merged.Length){
            throw new Exception("Index does not match end length of merge");
        }
        
        return merged;
    }
    
    private double getMedian(int[] arr) {
        // need some work if we have an even length
        if(arr.Length % 2 == 0){
            int firstMiddle = arr.Length / 2;
            double sum = arr[firstMiddle] + arr[firstMiddle - 1];
            return sum / 2;
        }
        else {
            return arr[(arr.Length / 2)];
        }
    }
}
