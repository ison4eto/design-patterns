using System;

public abstract class Approver
{
    protected Approver successor { get; set; }

    public abstract void ProcessRequest(Project Project);
}
