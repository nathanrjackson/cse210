class Scripture
{
    private string _reference;
    private List<Word> _scripture_words;
    private List<int> _visible_indices;
    private HashSet<int> _hidden_indices;
    private Random _random;

    public Scripture(string text, Reference reference)
    {
        _reference = reference.ToString();
        _scripture_words = text.Split(" ").Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void HideWords(int count = 3)
    {
        _visible_indices = _scripture_words.Select((word, index) => new {word, index})
            .Where(x => !x.word.IsHidden())
            .Select(x => x.index)
            .ToList();
        
        count = Math.Min(count, _visible_indices.Count);

        _hidden_indices = new HashSet<int>();
        while (_hidden_indices.Count < count)
        {
            int random_index = _random.Next(_visible_indices.Count);
            _hidden_indices.Add(_visible_indices[random_index]);
        }

        foreach (var index in _hidden_indices)
        {
            _scripture_words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _scripture_words.All(word => word.IsHidden());
    }

    public override string ToString()
    {
        return $"{_reference} {string.Join(" ", _scripture_words)}";
    }
}