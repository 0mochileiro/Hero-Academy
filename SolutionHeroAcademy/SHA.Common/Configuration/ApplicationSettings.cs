namespace SHA.Common.Configuration
{
    public static class ApplicationSettings
    {
        public static readonly string SHA_STORAGE_PATH = "SHA_STORAGE_PATH";
    }

    public static class ApplicationSettingsManager
    {
        public static string GetApplicationStoragePath()
        {
            string path = Environment.GetEnvironmentVariable(ApplicationSettings.SHA_STORAGE_PATH)?? string.Empty;

            if (string.IsNullOrEmpty(path))
            {
                throw new Exception($"The environment variable '{ApplicationSettings.SHA_STORAGE_PATH}' is mandatory for operation and is not defined.");
            }

            return path;
        }
    }
}
