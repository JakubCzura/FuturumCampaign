namespace FuturumCampaign.Models
{
    public class Town
    {
        public Town() { }

        public Town(string name)
        {
            Name = name;
        }

        public string Name { get; set; } = default!;
    }
}