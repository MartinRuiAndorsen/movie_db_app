using System.IO.Compression;

namespace movie_backend.Model
{
    public class Datasets
    {
        public static bool Unzip(string zipPath, string zipFilename, string extractDirectory)
        {
            using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
            {
                try
                {
                    ZipArchiveEntry? entry = archive.GetEntry(zipFilename);
                    if (entry is null)
                    {
                        return false;
                    }
                    entry.ExtractToFile(zipFilename, true); // Overwrite if already zipped
                    return true;
                } catch(Exception e)
                {
                    Console.WriteLine($"ERROR: {e.Message}");
                    return false;
                }
            }
        }
    }
}
