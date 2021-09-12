using System.Configuration;

namespace FormsUI.Utilities
{
    public static class ConfigurationHelper
    {
        static ConfigurationHelper()
        {
            _configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        private static Configuration _configuration;

        public static string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static void SetSetting(string key, string value)
        {
            _configuration.AppSettings.Settings[key].Value = value;
            _configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
