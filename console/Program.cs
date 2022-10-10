using System.Collections;

ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    ListNode start = new ListNode(-1);
    ListNode curr = start;
    while(list1 != null && list2 != null){
        if(list1.val < list2.val){
            curr.next = list1;
            list1 = list1.next;
        }
        else{
            curr.next = list2;
            list2 = list2.next;
        }
        curr = curr.next;
    }
    curr.next = list1 == null ? list2 : list1;

    return start.next;
}

var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var list2 = new ListNode(1, new ListNode(3, new ListNode(5)));

var result = MergeTwoLists(list1,list2);
while(result != null){
    Console.Write(result.val);
    Console.Write(" ");
    result = result.next;
}
