using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CSC350_Project1
{
    public struct avoidLinkedPCB
    {
        public int parent;
        public int first_child;
        public int younger_sibling;
        public int older_sibling;

        public avoidLinkedPCB(int parent, int first_child, int younger_sibling, int older_sibling)
        {
            this.parent = parent;
            this.first_child = first_child;
            this.younger_sibling = younger_sibling;
            this.older_sibling = older_sibling;
        }
    }

    public class AvoidLinkedPCB_Controller
    {
        //public int length;
        public avoidLinkedPCB[] pcb_arr = new avoidLinkedPCB[6];
        private int current_index = 0;
        private int[] indexArr = new int[10]; //1 means occupied 0 means unoccupied
        private int temp;
        
        public AvoidLinkedPCB_Controller()
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
        public void create(int parent_index)
        {
            //int temp = 0;

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

            if (pcb_arr[parent_index].first_child == 0)
            {
                pcb_arr[parent_index].first_child = current_index;
            }
            else
            {
                if (pcb_arr[pcb_arr[parent_index].first_child].younger_sibling == 0)
                {
                    pcb_arr[pcb_arr[parent_index].first_child].younger_sibling = current_index;
                    pcb_arr[current_index].older_sibling = pcb_arr[parent_index].first_child;
                }
                else
                {
                    
                };
            };
        }
    }
}