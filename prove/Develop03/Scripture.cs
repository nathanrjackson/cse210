class Scripture
{
    private string _reference;
    private List<Word> _scriptureWords;
    private List<int> _visibleIndicies;
    private HashSet<int> _hiddenIndices;
    private Random _random;

    public Scripture(string text, Reference reference)
    {
        _reference = reference.ToString();
        _scriptureWords = text.Split(" ").Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void HideWords(int count = 3)
    {
        _visibleIndicies = _scriptureWords.Select((word, index) => new {word, index})
            .Where(x => !x.word.IsHidden())
            .Select(x => x.index)
            .ToList();
        
        count = Math.Min(count, _visibleIndicies.Count);

        _hiddenIndices = new HashSet<int>();
        while (_hiddenIndices.Count < count)
        {
            int random_index = _random.Next(_visibleIndicies.Count);
            _hiddenIndices.Add(_visibleIndicies[random_index]);
        }

        foreach (var index in _hiddenIndices)
        {
            _scriptureWords[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _scriptureWords.All(word => word.IsHidden());
    }

    public override string ToString()
    {
        return $"{_reference} {string.Join(" ", _scriptureWords)}";
    }
}