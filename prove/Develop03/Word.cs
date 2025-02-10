class Word
{
    private string _text;
    private bool _is_hidden;

    public Word(string text, bool is_hidden = false)
    {
        _text = text;
        _is_hidden = is_hidden;
    }

    public void Hide()
    {
        _text = new string('-', _text.Length);
        _is_hidden = true;
    }

    public bool IsHidden()
    {
        return _is_hidden;
    }

    public override string ToString()
    {
        return _text;
    }
}