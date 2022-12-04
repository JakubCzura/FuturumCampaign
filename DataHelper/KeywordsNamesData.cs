using FuturumCampaign.DirectoriesHelper;
using FuturumCampaign.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace FuturumCampaign.DataHelper
{
    public static class KeywordsNamesData
    {
        /// <summary>
        /// Save keywords list to json file
        /// </summary>
        /// <param name="towns">Keywords to save</param>
        /// <returns>True if keywords are saved, otherwise false</returns>
        public static bool SaveKeywordsNames(List<string> towns)
        {
            try
            {
                string fullPath = Path.Combine(ApplicationDirectories.GetDataDirectoryFullName(), Names.KeywordsJson);
                var json = Json.Serialize(towns);
                File.WriteAllText(fullPath, json);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error while saving keywords");
                return false;
            }
        }

        /// <summary>
        /// Read keywords list from json file
        /// </summary>
        /// <returns>List of keywords</returns>
        public static List<string> ReadKeywordsNames()
        {
            try
            {
                string fullPath = Path.Combine(ApplicationDirectories.GetDataDirectoryFullName(), Names.KeywordsJson);
                if (File.Exists(fullPath))
                {
                    string json = File.ReadAllText(fullPath);
                    if (json.Length > 1)
                    {
                        return Json.Deserialize<List<string>>(json);
                    }
                    else
                    {
                        return new List<string>();
                    }
                }
                else
                {
                    File.Create(fullPath);
                    return new List<string>();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error while reading keywords' data");
                return new List<string>();
            }
        }
    }
}