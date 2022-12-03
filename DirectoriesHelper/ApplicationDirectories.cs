using System;
using System.IO;

namespace FuturumCampaign.DirectoriesHelper
{
    public static class ApplicationDirectories
    {
        /// <summary>
        /// Gets the application base directory that the assembly resolver uses for probe to assemblies
        /// </summary>
        /// <returns>The base directory that the assembly resolver uses to probe for assemblies</returns>
        public static string GetBaseDirectory()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
        }

        /// <summary>
        /// Gets full path for Data directory
        /// </summary>
        /// <returns>Full path for Data directory</returns>
        public static string GetDataDirectoryFullName()
        {
            return Path.Combine(GetBaseDirectory(), Names.DataDirectoryName);
        }

        /// <summary>
        /// Creates a new directory if it doesn't already extists
        /// </summary>
        /// <param name="path">Path where the directory will be created</param>
        /// <param name="name">Name of the directory</param>
        public static void CreateNewDirectory(string path, string name)
        {
            Directory.CreateDirectory(Path.Combine(path, name));
        }

        /// <summary>
        /// Creates Data directory
        /// </summary>
        public static void CreateDataDirectory()
        {
            CreateNewDirectory(GetBaseDirectory(), Names.DataDirectoryName);
        }
    }
}