using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace StudentApp.Backend.Common.Logic
{
    public static class AppConfiguration
    {
        private static Configuration GetConfig(Type type)
        {
            var dllLoc = new StringBuilder(
                new Uri(type.Assembly.CodeBase).LocalPath)
                .Append(CommonLiterals.ConfigExtension)
                .ToString();

            var fileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = dllLoc
            };

            return ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        }

        public static string GetConnectionString(Type type)
        {
            return GetConfig(type)
                .ConnectionStrings
                .ConnectionStrings[CommonLiterals.VuelingCrudConnectionName]
                .ConnectionString;
        }

    }
}
