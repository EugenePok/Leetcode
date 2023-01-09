/*
 * @lc app=leetcode id=208 lang=csharp
 *
 * [208] Implement Trie (Prefix Tree)
 */

// @lc code=start
public class Trie
{
    class TrieNode
    {
        public char val;
        public bool isWord;
        public TrieNode[] children = new TrieNode[26];
        public TrieNode() { }
        public TrieNode(char c)
        {
            TrieNode node = new TrieNode();
            node.val = c;
        }
    }

    private TrieNode root = new TrieNode(' ');
    public Trie()
    {

    }

    public void Insert(string word)
    {
        TrieNode node = root;
        foreach (var w in word)
        {
            if (node.children[w - 'a'] == null)
                node.children[w - 'a'] = new TrieNode(w);
            node = node.children[w - 'a'];
        }
        node.isWord = true;
    }

    public bool Search(string word)
    {
        TrieNode node = root;
        foreach (var w in word)
        {
            if (node.children[w - 'a'] == null)
                return false;
            node = node.children[w - 'a'];
        }
        return node.isWord;
    }

    public bool StartsWith(string prefix)
    {
        TrieNode node = root;
        foreach (var w in prefix)
        {
            if (node.children[w - 'a'] == null)
                return false;
            node = node.children[w - 'a'];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
// @lc code=end

