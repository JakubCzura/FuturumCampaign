using FuturumCampaign.DirectoriesHelper;
using FuturumCampaign.Models;
using FuturumCampaign.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace FuturumCampaign.DataHelper
{
    public static class CampaignsData
    {
        /// <summary>
        /// Save campaigns list to json file
        /// </summary>
        /// <param name="campaigns">Campaigns to save</param>
        /// <returns>True if campaigns are saved, otherwise false</returns>
        public static bool SaveCampaigns(List<Campaign> campaigns)
        {
            try
            {
                string fullPath = Path.Combine(ApplicationDirectories.GetDataDirectoryFullName(), Names.CampaignsJson);
                var json = Json.Serialize(campaigns);
                File.WriteAllText(fullPath, json);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error while saving campaign");
                return false;
            }
        }

        /// <summary>
        /// Read campaigns list from json file
        /// </summary>
        /// <returns>List of campaigns</returns>
        public static List<Campaign> ReadCampaigns()
        {
            try
            {
                string fullPath = Path.Combine(ApplicationDirectories.GetDataDirectoryFullName(), Names.CampaignsJson);
                if (File.Exists(fullPath))
                {
                    string json = File.ReadAllText(fullPath);
                    if(json.Length > 1)
                    {
                        return Json.Deserialize<List<Campaign>>(json);
                    }
                    else
                    {
                        return new List<Campaign>();
                    }                    
                }
                else
                {
                    File.Create(fullPath);
                    //MessageBox.Show("Error while reading campaigns' data");
                    return new List<Campaign>();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error while reading campaigns' data");
                return new List<Campaign>();
            }
        }
    }
}