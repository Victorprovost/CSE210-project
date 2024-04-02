using System;

public abstract class Goal
{
    protected string name;
    protected int points;

    public string Name => name;
    public int Points => points;

    public abstract void RecordEvent();
    public abstract string GetGoalStatus();
}
