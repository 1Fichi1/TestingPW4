using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string defaultPath = @"C:\Users\batyr\source\repos\FileFormatCounter\DAP";
        string defaultExtension = ".txt";

        Console.WriteLine($"Введите путь к директории или нажмите Enter для использования {defaultPath}:");
        string path = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(path)) path = defaultPath;

        Console.WriteLine($"Введите расширение файла или нажмите Enter для использования {defaultExtension}:");
        string extension = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(extension)) extension = defaultExtension;

        IFileDataObject fileDataObject = new FileDataObject();
        var manager = new FileCounterManager(fileDataObject);

        int count = manager.CountFilesWithExtension(path, extension);

        Console.WriteLine($"Количество файлов с расширением '{extension}': {count}");
    }
}
