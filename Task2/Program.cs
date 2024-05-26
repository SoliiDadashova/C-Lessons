using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12.Task1
{
    public class Program
    {
        const string myPath = @"C:\Users\compo\Downloads";
        static void Main(string[] args)
        {
            string[] directories = Directory.GetDirectories(myPath);
            string[] files = Directory.GetFiles(myPath);


            string imagePath = Path.Combine(myPath, "Images");
            CreateDirectory(imagePath);
            string videoPath = Path.Combine(myPath, "Videos");
            CreateDirectory(videoPath);
            string documentsPath = Path.Combine(myPath, "Documents");
            CreateDirectory(documentsPath);

            string othersPath = Path.Combine(myPath, "Other Files");
            CreateDirectory(othersPath);
            foreach (var directory in directories)
            {
                if (Directory.GetFiles(directory).Length == 0 && Directory.GetDirectories(directory).Length == 0)
                {
                    Directory.Delete(directory);
                }
            }
            foreach (var file in files)
            {
                string extension = Path.GetExtension(file).ToLower();
                string fileName = Path.GetFileName(file);
                switch (extension)
                {
                    case ".jpg":
                    case ".jpeg":
                    case ".png":
                    case ".gif":
                        File.Move(file, Path.Combine(imagePath, fileName));
                        break;
                    case ".mp4":
                    case ".avi":
                    case ".mov":
                        File.Move(file, Path.Combine(videoPath, fileName));
                        break;
                    case ".pdf":
                    case ".doc":
                    case ".docx":
                    case ".xls":
                    case ".xlsx":
                    case ".ppt":
                    case ".pptx":
                        File.Move(file, Path.Combine(documentsPath, fileName));
                        break;
                    default:
                        File.Move(file, Path.Combine(othersPath, fileName));
                        break;
                }

            }

        }
        public static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
