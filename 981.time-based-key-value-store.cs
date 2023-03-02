/*
 * @lc app=leetcode id=981 lang=csharp
 *
 * [981] Time Based Key-Value Store
 */

// @lc code=start
public class TimeMap
{
    Dictionary<string, List<(int, string)>> Hash;
    public TimeMap()
    {
        Hash = new Dictionary<string, List<(int, string)>>();
    }

    public void Set(string key, string value, int ts)
    {
        if (!Hash.ContainsKey(key))
            Hash.Add(key, new List<(int, string)>());
        Hash[key].Add((ts, value));
    }

    public string Get(string key, int ts)
    {
        string result = string.Empty;
        if (!Hash.ContainsKey(key))
            return result;
        var arr = Hash[key];
        int lo = 0, hi = arr.Count() - 1;
        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            //If we do not have exact timestamp, find the most recent one before it
            if (arr[mid].Item1 == ts)
                return arr[mid].Item2;
            else if (arr[mid].Item1 < ts)
            {
                result = arr[mid].Item2;
                lo = mid + 1;
            }
            else
                hi = mid - 1;
        }
        return result;
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */
// @lc code=end

