using System.Collections;

int FirstBadVersion(int n) {
    int start = 1;
    int end = n;
    while(start < end){
        int mid = start + (end-start)/2;
        if(IsBadVersion(mid))
            end = mid;
        else
            start = mid + 1;
    }
    return start;
}

bool IsBadVersion(int n) => n >= 4;

Console.WriteLine(FirstBadVersion(20));