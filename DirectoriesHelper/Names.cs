namespace FuturumCampaign.DirectoriesHelper
{
    public static class Names
    {
        /// <summary>
        /// Name of directory to store user's data
        /// </summary>
        public static string DataDirectoryName { get; } = "Data";

        /// <summary>
        /// Name of file with campaigns' data
        /// </summary>
        public static string CampaignsJson { get; } = "Campaigns.json";

        /// <summary>
        /// Name of file with towns' data
        /// </summary>
        public static string TownsJson { get; } = "Towns.json";

        /// <summary>
        /// Name of file with keywords' data
        /// </summary>
        public static string KeywordsJson { get; } = "Keywords.json";
    }
}