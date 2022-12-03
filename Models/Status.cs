namespace FuturumCampaign.Models
{
    public class Status
    {
        /// <summary>
        /// Values for campaign's status
        /// </summary>
        public enum Values
        {
            On,
            Off
        }

        public string StatusValue { get; set; } = default!;
    }
}