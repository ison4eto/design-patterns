using System;

public class Manager : Approver
{
    public override void ProcessRequest(Project Project)
    {
        if (Project.Amount < 10000.0)
        {
            Console.WriteLine("{0} approved request# {1}",
            this.GetType().Name, Project.Number);
        }
        else if (Successor != null)
        {
            Successor.ProcessRequest(Project);
        }
    }
}