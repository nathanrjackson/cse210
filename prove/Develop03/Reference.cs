class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verse_start)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse_start;
    }
    
    public Reference(string book, int chapter, int verse_start, int verse_end)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse_start;
        _verseEnd = verse_end;
    }

    public override string ToString()
    {
        if (_verseEnd == 0)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}