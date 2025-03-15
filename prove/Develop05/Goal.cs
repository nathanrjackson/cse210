class Goal
{
    private string _name;
    private string _desc;
    private bool _isComplete;
    private int _points;

    public Goal() { }
    public Goal(string name, string desc, bool isComplete, int points)
    {
        _name = name;
        _desc = desc;
        _isComplete = isComplete;
        _points = points;
    }

    public string GetName() { return _name; }
    public string GetDesc() { return _desc; }

    public virtual int GetPoints() { return _points; }
    public virtual string Save() { return $"{_name}|{_desc}|{_isComplete}|{_points}"; }
    public virtual void MarkComplete() { _isComplete = true; }
    public virtual string RenderText() { return $"{(_isComplete ? "[X]" : "[ ]")} {_name} ({_desc})"; }
    public virtual bool IsComplete() { return _isComplete; }
}