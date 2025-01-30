class Entry
{
    public string _date;
    public string _prompt;
    public string _text;
    public string _readBom;

    public Entry(string date, string prompt, string text, string readBom)
    {
        _date = date;
        _prompt = prompt;
        _text = text;
        _readBom = readBom;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} {_prompt}");
        Console.WriteLine(_text);
        Console.WriteLine($"Read in Book of Mormon: {_readBom}");
    }
}