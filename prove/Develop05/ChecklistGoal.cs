class ChecklistGoal : Goal
{
    private int _requiredCompletions;
    private int _actualCompletions;
    private int _bonusPoints;

    public ChecklistGoal() { }
    public ChecklistGoal(string name, string desc, bool isComplete, int points, int requiredCompletions, int actualCompletions, int bonusPoints)
        : base(name, desc, isComplete, points) 
    {
        _requiredCompletions = requiredCompletions;
        _actualCompletions = actualCompletions;
        _bonusPoints = bonusPoints;
    }

    public override int GetPoints() 
    {
        if (_requiredCompletions == _actualCompletions)
        {
            return base.GetPoints() + _bonusPoints;
        }
        else
        {
            return base.GetPoints();
        }
    }

    public override string Save() { return $"{GetName()}|{GetDesc()}|{IsComplete()}|{GetPoints()}|{_requiredCompletions}|{_actualCompletions}|{_bonusPoints}"; }

    public override void MarkComplete() 
    {
        if (_actualCompletions < _requiredCompletions)
        {
            _actualCompletions += 1;
        }
        
        if (_actualCompletions == _requiredCompletions)
        {
            base.MarkComplete();
        }
    }

    public override string RenderText() { return $"{(IsComplete() ? "[X]" : "[ ]")} {GetName()} ({GetDesc()}) -- Currently completed: {_actualCompletions}/{_requiredCompletions}"; }
}