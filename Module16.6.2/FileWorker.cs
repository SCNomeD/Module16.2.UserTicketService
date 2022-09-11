namespace Module16._6._2
{
    public class FileWorker
    {
        private string GetSafeFilename(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }
    }
}
