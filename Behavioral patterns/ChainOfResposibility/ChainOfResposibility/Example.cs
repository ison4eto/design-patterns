﻿using System;

namespace ChainOfResposibility
{
    class Example
    {
        static void Main()
        {
            Approver Sameer = new President();
            Approver Abhi = new CEO();
            Approver Rahul = new Manager();

            Rahul.SetSuccessor(Sameer);
            Sameer.SetSuccessor(Abhi);

            // Generate and process purchase requests
            Project p = new Project(1, 350.00, "Test Postponed");
            Rahul.ProcessRequest(p);
            p = new Project(2, 32590.10, "Annual Function");
            Rahul.ProcessRequest(p);
            p = new Project(3, 122100.00, "Renovation of Classes");
            Rahul.ProcessRequest(p);

            Console.ReadKey();
        }
    }
}
