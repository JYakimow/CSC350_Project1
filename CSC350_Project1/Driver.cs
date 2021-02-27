using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CSC350_Project1
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");

            /*
            PCB_Controller PCB_List = new PCB_Controller();
            PCB_List.init();
            PCB_List.create(0);
            PCB_List.create(0);
            PCB_List.create(2);
            PCB_List.create(0);
            Console.WriteLine("Finished creating PCB");
            PCB_List.print_all(0);
            Console.WriteLine("print finished");

            PCB_List.destroy(0);
            Console.WriteLine("destroy finshed");

            PCB_List.print_all(0);
            */

            AvoidLinkedPCB_Controller PCB_List2 = new AvoidLinkedPCB_Controller();
            PCB_List2.init();
            PCB_List2.create(0);
            PCB_List2.create(0);
            PCB_List2.create(0);
            PCB_List2.create(0);

        }
    }
}
