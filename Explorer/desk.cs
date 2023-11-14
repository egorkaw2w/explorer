using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Explorer
{
    internal class desk
    {
        public static string diski()
        {
            Console.Clear();
            Console.WriteLine("  Проводник");
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo driver in allDrives)
            {
                Console.WriteLine($"  {driver.Name}  Свободно {driver.AvailableFreeSpace / (1024 * 1024 * 1024)} из {driver.TotalSize / (1024 * 1024 * 1024)}");
            }
            menu menu = new menu(1, allDrives.Length);
            int pos = menu.Show();

            return allDrives[pos].Name;
        }
        public static void view(string path) 
        {
                var a = Directory.GetDirectories(path);
                Console.Clear();
            Console.WriteLine("Проводник");
            string[] files = Directory.GetFiles(path);
            int asd = 0;
            List<string> vse = new List<string>();

            for (int i = 0; i < a.Length; i++)
            {
                vse.Add(a[i]);
            }
            for (int i = 0; i < files.Length; i++)
            {
                vse.Add(files[i]);
            }

            foreach (var i in a)
                {
                asd++;
                DirectoryInfo directoryInfo = new DirectoryInfo(i);
                Console.Write($"  {i}");
                Console.SetCursorPosition(60,asd);
                Console.WriteLine(directoryInfo.CreationTime);
            }
             
            int das = asd;
            foreach (string file in files)
            {
                das++;
                DirectoryInfo directoryInfo = new DirectoryInfo(file);
                Console.WriteLine("  " + file);
                Console.SetCursorPosition(60, das);
                Console.WriteLine(directoryInfo.CreationTime);

            }
            
           
            menu menu = new menu(1, a.Length + files.Length);

            int pos = menu.Show();

            string ext = new FileInfo(vse[pos]).Name; //смотри, ты сначала создаешь файл инфо, и туда помещаешь путь до файла. через .Name ты можешь взять название файла, и тогда ты получишь только вот это 
            if(ext.Contains("."))
            {
                Process.Start(new ProcessStartInfo { FileName = vse[pos], UseShellExecute = true });
            }
            
            else
            {
                view(vse[pos]);
            }
            
            
            
        }
    }
}
