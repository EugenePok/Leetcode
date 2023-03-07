/*
 * @lc app=leetcode id=721 lang=csharp
 *
 * [721] Accounts Merge
 */

// @lc code=start
public class Solution
{
    int[] parent;
    int[] sz;

    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        parent = new int[accounts.Count()];
        sz = new int[accounts.Count()];
        for (int i = 0; i < accounts.Count(); i++)
        {
            parent[i] = i;
            sz[i] = 1;
        }

        Dictionary<string, int> EmailsBelongsToWho = new();
        for (int i = 0; i < accounts.Count(); i++)
        {
            for (int j = 1; j < accounts[i].Count(); j++)
            {
                if (EmailsBelongsToWho.ContainsKey(accounts[i][j]))
                    Union(EmailsBelongsToWho[accounts[i][j]], i);
                else
                    EmailsBelongsToWho.Add(accounts[i][j], i);
            }
        }

        Dictionary<string, HashSet<string>> result = new();
        for (int i = 0; i < accounts.Count(); i++)
        {
            var root = GetRoot(parent[i]);
            var key = $"{accounts[root][0]}-{root}";
            if (!result.ContainsKey(key))
                result.Add(key, new HashSet<string>(accounts[i]));
            else
            {
                for (int j = 0; j < accounts[i].Count(); j++)
                    result[key].Add(accounts[i][j]);
            }
        }

        List<IList<string>> output = new();
        foreach (var set in result.Values)
        {
            var temp = set.ToList();
            var name = temp[0];
            temp.RemoveAt(0);
            temp.Sort(StringComparer.Ordinal);

            var newList = new List<string>() { name };
            newList.AddRange(temp);
            output.Add(newList);
        }

        return output;
    }

    int GetRoot(int a)
    {
        while (a != parent[a])
        {
            a = parent[a];
            parent[a] = parent[parent[a]];
        }
        return a;
    }

    void Union(int a, int b)
    {
        var root_a = GetRoot(a);
        var root_b = GetRoot(b);
        if (root_a == root_b)
            return;
        if (sz[root_a] > sz[root_b])
        {
            parent[root_b] = root_a;
            sz[root_a] += sz[root_b];
        }
        else
        {
            parent[root_a] = root_b;
            sz[root_b] += sz[root_a];
        }
    }

}
// @lc code=end

