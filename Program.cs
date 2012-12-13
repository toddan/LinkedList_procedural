using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        /* 
         * Simple Linkedlist example
         * Tord Munk
         * 
         * ABOUT:
         *  This is a tiny implementation of a linkedlist. Just to give someone a simple start -
         *  on how to build linkedlist data structures.
         *  
         * LICENSE:
         *  Do what you want with it
         * */

        /*
         * List node that stores a pointer/ref to the next node
         * and hold data of the node. This node stores string data
         * */
        class Node
        {
            public Node next;
            public string Data;

            /*Constructor overloading so we can allocate a node with no data */
            public Node() { }

            public Node(string d)
            {
                Data = d;
            }
        }

        /*
         * The head of the list. This is where we start and keep track of the lists head
         * */
        static Node HEAD = new Node();

        /*
         * add string data to a node and then connect it to the head.
         * 
         * Like this:
         * 
         * new_node -> next -> HEAD 
         * HEAD -> new_node
         * 
         * This way we form a "cirle" so the list becomes connected
         * 
         * */
        static void append(string data)
        {
            Node new_node = new Node(data);
            new_node.next = HEAD;
            HEAD = new_node;
        }

        /*
         * Here we traverse our list and stops at given index
         * 
         * Take note that we create a CURR node to point/ref to the HEAD node.
         * Then we use the CURR node to traverse. So we do not change the state
         * of the HEAD node
         * */
        static void print_node_at(int index)
        {
            Node CURR = HEAD;
            int i = 0;
            while (CURR.next != null /* as long as the next node is not null we keep traversing*/)
            {
                if (i == index)
                {
                    Console.WriteLine(CURR.Data);
                }
                else
                {
                    /* connect the current node to the next one so we can traverse thru the list */
                    CURR = CURR.next;
                }
                i++;
            }
        }

        /*
         * Traverse and print all nodes.
         * Using a CURR node pointer/ref 
         * */
        static void print_all_nodes()
        {
            Node CURR = HEAD;
            while (CURR.next != null)
            {
                Console.WriteLine(CURR.Data);
                CURR = CURR.next;
            }
        }

        static void Main(string[] args)
        {
            /* add some strings to the list */
            append("martin");
            append("tord");
            append("kalle");

            /* print the node at index 1 */
            Console.WriteLine("node at index 1:");
            print_node_at(1);

            Console.WriteLine('\n');

            /* print all nodes in the linkedlist */
            Console.WriteLine("All the nodes:");
            print_all_nodes();
            Console.ReadKey();
        }
    }
}
