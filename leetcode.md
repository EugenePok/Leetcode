::: mermaid
flowchart LR;
classDef easy fill:green
classDef intermediate fill:orange

TypeOfProblem{{Type of Problem}}
1[Arrays and Strings]
2[Linked Lists]
3[Binary Trees and Binary Search Trees]
4[Recursion and Backtracking]
5[Dynamic Programming]
6[Hash Tables and Sets]
7[Stack and Queue]
8[Binary Search]
9[Graphs and Traversal Algorithms]
10[Sorting and Searching]
11[Bit Manipulation]
12[Math]

    TypeOfProblem --> 1 --> Q1[Q1 - Two Sums: focus on 2 numbers and solve using hashmap]:::easy
    1 --> Q121["Q121 - Sell Stock: focus on the godly formula on d[day][holding(bit)][sold count]]"]:::easy
    TypeOfProblem --> 2 --> Q206[Q206 - Reverse Linked List : creating new node and slowly move the head forward.]:::easy
    2 --> Q21["Q21 - Merge 2 sorted lists : idea is correct that need to pick lowest of 2, but rmb dont recreate the node (memory) and create dummy head for first and return head.next as result"]:::easy
    TypeOfProblem --> 3 --> Q104["Q104 - Max Depth of BTree : well just recursive and max(left,right) +1"]:::easy
    3 --> Q226["Q226 - invert BTree : Basically bfs and perform reverse action on each node."]:::easy
    TypeOfProblem --> 4 --> Q78["Q78 - Subsets : core idea is just DP of choose or not choose"]:::intermediate
    4 --> Q17["Q17 - Letter combi of phone number : dont bother with the abc calculation, basically same core idea with Q4"]:::intermediate
    TypeOfProblem --> 5
    TypeOfProblem --> 6 --> Q242["Q242 - Anagram : well it will be 2n, add char to array of 26 and minus."]:::easy
    TypeOfProblem --> 7 --> Q20["Q20 - Valid Parentheses : just stack."]:::easy
    TypeOfProblem --> 8 --> Q704["Q704 - Binary Search : Sick bs..., remember dont overflow and if stuck means your upper/lower boundary are wrong."]:::easy
    8 --> Q35["35 - Search Insert Position : just instead of return null, insert mid +1"]:::easy
    TypeOfProblem --> 9
    TypeOfProblem --> 10
    TypeOfProblem --> 11
    TypeOfProblem --> 12

:::
