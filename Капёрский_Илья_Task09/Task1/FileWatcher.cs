using System;
using System.Collections.Generic;
using System.IO;


namespace Task1
{
    public class FileWatcher
    {
        public static string Path = "C:\\Новая папка";
        public static string Temp = @"temp"; //папка создается в дебаге
        public static string[] AllDates = new string[100];
        public static int i = 0;


        public static DateTime ReadDate()
        {
            Console.WriteLine(">>>Введите дату в формате дд.мм.гггг чч:мм:сс");
            DateTime time = Convert.ToDateTime(Console.ReadLine());
            return time;
        }

        

        //метод Clone(DirectoryInfo savingfolder, DirectoryInfo tempfolder) клонирует savingfolder в tempfolder
        public static void Clone(DirectoryInfo savingfolder, DirectoryInfo tempfolder)
        {
            foreach (FileInfo file in savingfolder.EnumerateFiles())
            {
                FileInfo newfile = new FileInfo(tempfolder.FullName + '\\' + file.Name);
                using (newfile.Create()) { }
                file.CopyTo(newfile.FullName, true);
            }

            foreach (DirectoryInfo dir in savingfolder.EnumerateDirectories())
            {
                DirectoryInfo newdir = tempfolder.CreateSubdirectory(dir.Name);
                Clone(dir, newdir);
            }
        }

        //событие изменения файла
        public static void onChange(object source, FileSystemEventArgs e)
        {
            //сообщаем об изменении
            Console.WriteLine("Файл '{0}' был изменён!", e.FullPath);

            //сохраняем изменения в папку с именем текущей даты
            char[] c = DateTime.Now.ToString().ToCharArray();
            while (Array.IndexOf(c, ':') != -1)
                c[Array.IndexOf(c, ':')] = '-';
            string date = new string(c);
            DirectoryInfo tempfolder = new DirectoryInfo(Temp + date);
            tempfolder.Create();
            Clone(new DirectoryInfo(Path), tempfolder);
            AllDates[i] = date;
            i++;
            

        }

        public void Watching()
        {
            Console.WriteLine("\nРежим наблюдения включён.");
            FileSystemWatcher watcher = new FileSystemWatcher(Path, "*.txt");
            watcher.IncludeSubdirectories = true;
            //подписываемся на событие
            watcher.Changed += new FileSystemEventHandler(onChange);
            //начинам слежение
            watcher.EnableRaisingEvents = true;
            Console.WriteLine(">>>Нажмите \'0\' чтобы завершить наблюдение.");
            while (Console.Read() != '0') ;
            watcher.EnableRaisingEvents = false;

        }
         
        public void Return()
        {
            
            Console.WriteLine("Даты изменений");
            for (int j=0; j < i; j++)
            {
                Console.WriteLine(AllDates[j]);

            }

            //считываем дату
            DateTime date = ReadDate();
            char[] cdate = date.ToString().ToCharArray();
            while (Array.IndexOf(cdate, ':') != -1)
                cdate[Array.IndexOf(cdate, ':')] = '-';
            //откатываем
            Clone(new DirectoryInfo(Temp + new string(cdate)), new DirectoryInfo(Path));
            Console.WriteLine("Произведён откат на {0}", date.ToString());
        }
    }   
}