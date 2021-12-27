using System;

namespace ConsoleApp1
{
    public class Reader
    {
        public Reader(string path)
        {
            Path = path;
        }

        public string Path { get; set; }

        public string GetContent()
        {
            string result = "";
            try
            {
                if (File.Exists(Path))
                {
                    using StreamReader stream = File.OpenText(Path);
                    result = stream.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            return result;
        }

        public void SaveContent(string message)
        {
            try
            {
                using FileStream fileStream = File.Open(Path, FileMode.OpenOrCreate, FileAccess.Write);
                if (fileStream.CanWrite)
                {
                    using StreamWriter writer = new StreamWriter(fileStream);
                    writer.Write(message);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
