using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlly_linked_list
{

    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }

    class list
    {
        Node START;

        public list()
        {
            START = null;
        }
        public void addnode() //add a node in the list
        {
            int nim;
            string nm;
            Console.Write("\n Enter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = nim;
            newnode.name = nm;
            //if the node to be inserted is the first node 
            if (START == null || nim <= START.rollNumber)
            {
                if ((START != null) && (nim == START.rollNumber))
                {
                    Console.WriteLine("\n Duplicate roll numbers not allowed\n");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            // Locate the position of the new node in the list
            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.rollNumber))
            {
                if (nim == current.rollNumber)
                {
                    Console.WriteLine("\n Duplicate roll number not allowed\n");
                    return;
                }
                previous = current;
                current = current.next;
            }

            /*once the above for loop is executed, prev and current are positioned in such a 
              manner that the positon of the new node is added*/
            newnode.next = current;
            previous.next = newnode;
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
