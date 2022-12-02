namespace FuturumCampaign.Models
{
    public class Keyword
    {
        public Keyword() { }
        public Keyword(string word)
        {
            Word = word;
        }

        public string Word { get; set; } = default!;
    }
}