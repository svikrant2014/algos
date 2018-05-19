using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public class Node
    {
        public Node next;
        public int data;

        public void AddNodeStart(Node head, int data)
        {
            var temp = new Node();
            temp.data = data;

            temp.next = head;
            head = temp;
        }
    }
    public static class LinkedList
    {
        public static Node head = null;

        public static void AddNodeStart(int data)
        {
            var newnode = new Node();
            newnode.data = data;

            newnode.next = head;
            head = newnode;
        }

        public static void printlist()
        {
            Node temp  = head;

            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public static void insertatnth(int data, int pos)
        {
            Node temp = head;
            int currentpos=0;

            if(pos  == 1)
            {
                var newnode = new Node();
                newnode.data = data;
                head = newnode;
                return;
            }

            while(currentpos <=pos-2 || temp != null)
            {
                if(currentpos == pos-2)
                {
                    var newnode = new Node();
                    newnode.data = data;

                    newnode.next = temp.next;
                    temp.next = newnode;
                    return;
                }

                currentpos++;
                temp = temp.next;
            }
        }

        public static void delete(int pos)
        {
            if(pos == 1)
            {
                head = head.next;
                return;
            }

            int currentpos = 0;
            var temp = head;

            while(currentpos <=pos-2 || temp != null)
            {
                if(currentpos == pos-2)
                {
                    temp.next = temp.next.next;
                    return;
                }

                currentpos++;
                temp = temp.next;
            }

        }

        public static void reverse()
        {
            Node current = null;

            while(head != null)
            {
                var temp = head;
                var next = temp.next;
                temp.next = current;
                current = temp;
                head = next;
            }

            head = current;
        }

        public static void reverseusingrecursion(Node p)
        {
            if(p.next == null)
            {
                head = p;
                return;
            }

            reverseusingrecursion(p.next);
            var tmp = p.next;
            tmp.next = p;
            p.next = null;
        }

        public static void printll()
        {
            reverseusingrecursion(head);
        }
        public static void printusingrecursion(Node myhead)
        {
            if(myhead == null)
                return;

            Console.WriteLine(myhead.data);
            printusingrecursion(myhead.next);
        }

        public static void reverseprintusingrecursion(Node myhead)
        {
            if(myhead == null)
                return;

            reverseprintusingrecursion(myhead.next);
            Console.WriteLine(myhead.data);

        }

        public static void removedups()
        {
            var temp = head;

            while(temp != null)
            {
                var runner = temp;
                while(runner.next != null)
                {
                    if(temp.data == runner.next.data)
                    {
                        runner.next = runner.next.next; 
                    }

                    runner = runner.next;
                }
                temp = temp.next;
            }
        }

        public static Node findkthtolast(int k)
        {
            var node1 = head;
            var node2 = head;

            for(int i=0; i< k; i++)
            {
                node1 = node1.next;
            }

            while(node1 != null)
            {
                node1 = node1.next;
                node2 = node2.next;
            }

            return node2;
        }

        public static bool deletekthnode(Node p)
        {
            if(p.next == null || p== null)
                return false;

            p.data = p.next.data;
            p.next = p.next.next;

            return true;
        }
        public static Node partition(int x)
        {
            var beforeStart = new Node();
            var beforeEnd = new Node();
            var afterStart = new Node();
            var afterEnd = new Node();

            while(head != null)
            {
                Node next = head.next;
                
                if(head.data < x)
                {
                    if(beforeStart == null)
                    {
                        beforeStart = head;
                        beforeEnd = beforeStart;
                    }
                    else{
                        beforeEnd.next = head;
                        beforeEnd = head;
                    }
                }
                else{
                    if(afterStart == null)
                    {
                        afterStart =head;
                        afterEnd = afterStart;
                    }
                    else
                    {
                        afterEnd.next = head;
                        afterEnd = head;
                    }
                }

                head = head.next;
            }

            beforeEnd.next = afterStart;

            return beforeStart;
        }


        public static void addLists(Node list1, Node list2)
        {
            int carry = 0;

            var newList = new Node();

            while(list1!= null || list2 != null)
            {
                int data = list1.data+list2.data;
                carry = data%10;
                int val = data/10;

                newList.data = data;

                newList.next = head;
                head = newList;
            }

            if(list1!= null)
            {
                newList.data = list1.data;

                newList.next = head;
                head = newList;
            }
            if(list2!= null)
            {
                newList.data = list2.data;

                newList.next = head;
                head = newList;
            }
        }

    }



}