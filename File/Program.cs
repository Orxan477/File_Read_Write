using System;
using System.IO;

namespace File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = "E:\\Music\\Orxan"; // Dosyaların bulunduğu dizin yolu
            string targetText = "spotifydown.com - "; // Silmek istediğiniz metin

            try
            {
                string[] files = Directory.GetFiles(directoryPath, "*.mp3");

                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    string newFileName = fileName.Replace(targetText, "");

                    string newFilePath = Path.Combine(directoryPath, newFileName);
                    System.IO.File.Move(filePath, newFilePath);

                    Console.WriteLine($"Dosya adı değiştirildi: {fileName} -> {newFileName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
        }
    }
}
