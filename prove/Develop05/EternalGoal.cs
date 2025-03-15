class EternalGoal : Goal
{
    public EternalGoal() { }
    public EternalGoal(string name, string desc, bool isComplete, int points)
        : base(name, desc, isComplete, points) { }

    public override void MarkComplete() {  }
}