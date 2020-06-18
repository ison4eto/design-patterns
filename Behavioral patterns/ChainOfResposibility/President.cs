using System;

public class President : Approver
{
    public override void ProcessRequest(Project Project)
    {
        if (Project.Amount < 25000.0)
        {
            Console.WriteLine("{0} approved request# {1}",
            this.GetType().Name, Project.Number);
        }
        else if (successor != null)
        {
            successor.ProcessRequest(Project);
        }
    }
}
