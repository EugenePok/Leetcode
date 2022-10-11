using System.Collections;

int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;
        int mid = Mid(low,high);
        while(low < high){
            if(target > nums[mid])
                low = mid + 1;
            else 
                high = mid;
            mid = Mid(low,high); 
        }
        return target == nums[low] ? mid : -1;  
    }
int Mid(int low, int high) => low + (high-low) / 2;

Console.WriteLine(Search(new int[]{ -1,0,3,5,9,12 }, 9));