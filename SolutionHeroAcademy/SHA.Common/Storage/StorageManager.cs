
using SHA.Common.Configuration;
using SHA.Common.Enums;

namespace SHA.Common.Storage
{
    public class StorageManager
    {
        private readonly List<StoredFile> StoredFiles;

        public StorageManager()
        {
            StoredFiles = new List<StoredFile>
            {
                new StoredFile
                {
                    ID = new Guid("99691CB7-D0B5-4498-945E-FD0372D2D13F"),
                    Name = "homepage-card-background-image-first",
                    FileExtensionType = FileExtensionType.JPG
                },
                new StoredFile
                {
                    ID = new Guid("A5A3BC1D-2D1E-45A4-BEB9-19E1F3E0DB32"),
                    Name = "homepage-card-background-image-second",
                    FileExtensionType = FileExtensionType.JPG
                },
                new StoredFile
                {
                    ID = new Guid("B6C4DB2F-3E2F-4F4A-BA69-0E4D5F0F3E10"),
                    Name = "homepage-card-background-image-third",
                    FileExtensionType = FileExtensionType.JPG
                }
            };
        }

        private string GetImagePath(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return string.Empty; //TODO: Implement application-level logging for null or empty id.
            }

            var storedFile = StoredFiles.FirstOrDefault(f => f.ID.ToString().Equals(id, StringComparison.OrdinalIgnoreCase));

            if (storedFile is null)
            {
                return string.Empty; //TODO: Implement application-level logging for file not found.
            }

            return Path.Combine(ApplicationSettingsManager.GetApplicationStoragePath(), "Images", $"{storedFile.Name}.{storedFile.FileExtensionType.ToString().ToLower()}");
        }

        public byte[]? GetStoredImage(string id)
        {
            var path = GetImagePath(id);

            if (!File.Exists(path))
            {
                return null; //TODO: Implement application-level logging for file not existing.
            }

            try
            {
                return File.ReadAllBytes(path);
            }
            catch (Exception)
            {
                return null; //TODO: Implement application-level logging for the caught exception.
            }
        }
    }

    public class StoredFile
    {
        public Guid ID { get; set; }
        public required string Name { get; set; }
        public FileExtensionType FileExtensionType { get; set; }
    }
}
