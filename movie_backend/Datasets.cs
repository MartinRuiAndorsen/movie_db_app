namespace movie_backend
{
    public class Datasets
    {
        public static void Unzip(string zipPath, string extractDirectory, string unzippedName)
        {
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractDirectory);
            } catch (Exception e)   // TODO: Potentially check different exceptions
            {
                Console.WriteLine($"Failed to unzip, error: { e.Message }");
            }

        }
    }
}
