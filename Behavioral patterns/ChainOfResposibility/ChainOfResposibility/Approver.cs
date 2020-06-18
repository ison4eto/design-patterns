using System;

public abstract class Approver
{
    protected Approver Successor;

    public void SetSuccessor(Approver successor)
    {
        this.Successor = successor;
    }

    public abstract void ProcessRequest(Project Project);
}
