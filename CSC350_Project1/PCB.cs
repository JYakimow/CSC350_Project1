using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CSC350_Project1
{
    public struct process
    {
        public int parent;
        public LinkedList ll;
        
        public process(int parent, LinkedList ll)
        {
            this.parent = parent;
            this.ll = ll;
        }
    }

    public class PCB_Controller
    {
        //public int length;
        public process[] pcb_arr = new process[6];
        private int current_index = 0;
        private int[] indexArr = new int[6]; //1 means occupied 0 means unoccupied

        public PCB_Controller()
        {
           // this.parent_index = parent_index;
        }
        
        public void init()
        {
            //pcb_arr[0].parent = null;
            //Console.WriteLine(pcb_arr[0].parent);
            current_index = 1;
            indexArr[0] = 1;
        }
        /*
        public void initChild_ll()
        { 
            LinkedList current_index = 
        }
        */
        public void create(int parent_index)
        {
            for (int i = 0; i < indexArr.Length; i++)
            {
                if (indexArr[i] == 0)
                {
                    current_index = i;
                    indexArr[i] = 1;
                    //Console.WriteLine("new total: " + i);
                    break;
                }
            };
            pcb_arr[current_index].parent = parent_index;

            if (pcb_arr[parent_index].ll == null)
            {
                Console.WriteLine("new child of: " + parent_index.ToString());
                pcb_arr[parent_index].ll = new LinkedList();
                //Console.WriteLine("Test1: " + current_index);
                pcb_arr[parent_index].ll.add_first(current_index);
                Console.WriteLine("LinkedList indexes: ");
                pcb_arr[parent_index].ll.printNodes();
                //Console.WriteLine("if");
            }
            else
            {
                Console.WriteLine("new child of: " + parent_index.ToString());
                pcb_arr[parent_index].ll.add_last(current_index);
                Console.WriteLine("LinkedList indexes: ");
                pcb_arr[parent_index].ll.printNodes();
                //Console.WriteLine("else");
            };
        }
        public void print_all(int parent_index)
        {
            if (pcb_arr[parent_index].ll != null)
            {
                Node current = pcb_arr[parent_index].ll.head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    print_all(Convert.ToInt32(current.data));
                    current = current.next;
                }
                Console.WriteLine("point reached");
            }
            else 
            {
                //Console.WriteLine("else was called");
            }
        }
        public void destroy(int parent_index)
        {
            if (pcb_arr[parent_index].ll != null)
            {
                //pcb_arr[parent_index].ll.destroyNodes();

                Node current = pcb_arr[parent_index].ll.head;
                pcb_arr[parent_index].ll = null;
                while (current != null)
                {
                    object temp = current.data;
                    current.data = null;
                    //Console.WriteLine(parent_index);
                    destroy(Convert.ToInt32(temp));
                    Node temp2 = current.next;
                    current.next = null;
                    current = temp2;
                }
            }
            else if (pcb_arr[parent_index].ll == null)
            { 
            }
            else 
            {
                Console.WriteLine("end of");
            };
        }
    }
}