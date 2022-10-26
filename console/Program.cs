using System.Collections;

bool HasCycle(ListNode head) {
    ListNode walker = head;
    ListNode runner = head;
    while(runner!=null && runner.next!=null) {
        walker = walker.next;
        runner = runner.next.next;
        if(walker==runner) return true;
    }
    return false;     
}

ListNode key = new ListNode(2);
ListNode back = new ListNode(0, new ListNode(4, key));
key.next = back;
Console.WriteLine(HasCycle(new ListNode(3, key)));
