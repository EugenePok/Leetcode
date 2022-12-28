/*
 * @lc app=leetcode id=133 lang=csharp
 *
 * [133] Clone Graph
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution
{
    public Node dfs(Node node, Node copy, Node[] visited)
    {
        visited[copy.val] = copy;
        foreach (var n in node.neighbors)
        {
            if (visited[n.val] != null)
            {
                copy.neighbors.Add(visited[n.val]);
            }
            else
            {
                var newNode = new Node(n.val);
                copy.neighbors.Add(newNode);
                dfs(n, newNode, visited);
            }
        }
        return node;
    }

    public Node CloneGraph(Node node)
    {
        if (node == null) return node;
        Node copy = new Node(node.val);
        Node[] visited = new Node[101];
        Array.Fill(visited, null);
        dfs(node, copy, visited);
        return copy;
    }
}
// @lc code=end

