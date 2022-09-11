namespace Module16._4.Translator
{
    public class TranslateService
    {
        public Dictionary<string, string> _translation;

        public TranslateService()
        {
            _translation = new Dictionary<string, string>();
            _translation.Add("dog", "собака");
            _translation.Add("cat", "кошка");
        }
        public void AddTranslation(string oneWord, string twoWord)
        {
            _translation.Add(oneWord, twoWord);
        }

        public string GetTranslation(string word)
        {
            return _translation[word];
        }
    }
}
