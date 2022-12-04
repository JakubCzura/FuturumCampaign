using FuturumCampaign.DirectoriesHelper;
using FuturumCampaign.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace FuturumCampaign.DataHelper
{
    public static class TownsNamesData
    {
        /// <summary>
        /// Save towns list to json file
        /// </summary>
        /// <param name="towns">Towns to save</param>
        /// <returns>True if towns are saved, otherwise false</returns>
        public static bool SaveTownsNames(List<string> towns)
        {
            try
            {
                string fullPath = Path.Combine(ApplicationDirectories.GetDataDirectoryFullName(), Names.TownsJson);
                var json = Json.Serialize(towns);
                File.WriteAllText(fullPath, json);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error while saving towns");
                return false;
            }
        }

        /// <summary>
        /// Read towns list from json file
        /// </summary>
        /// <returns>List of towns</returns>
        public static List<string> ReadTownsNames()
        {
            try
            {
                string fullPath = Path.Combine(ApplicationDirectories.GetDataDirectoryFullName(), Names.TownsJson);
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
                MessageBox.Show(exception.Message, "Error while reading towns' data");
                return new List<string>();
            }
        }
    }
}