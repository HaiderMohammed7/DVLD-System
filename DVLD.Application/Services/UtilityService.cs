namespace DVLD.Application.Services
{
    public class UtilityService
    {
        public static string CopyImage(string sourceFile)
        {
            string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

            Directory.CreateDirectory(imagesFolder);

            string fileName = $"{Guid.NewGuid()}{Path.GetExtension(sourceFile)}";

            string destinationFile = Path.Combine(imagesFolder, fileName);

            File.Copy(sourceFile, destinationFile, true);

            return destinationFile;
        }
    }
}