class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text, bool is_hidden = false)
    {
        _text = text;
        _isHidden = is_hidden;
    }

    public void Hide()
    {
        _text = new string('-', _text.Length);
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public override string ToString()
    {
        return _text;
    }
}