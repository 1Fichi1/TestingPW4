using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileCounterManager
{
    private readonly IFileDataObject _fileDataObject;

    public FileCounterManager(IFileDataObject fileDataObject)
    {
        _fileDataObject = fileDataObject;
    }

    public int CountFilesWithExtension(string path, string extension)
    {
        try
        {
            var files = _fileDataObject.GetFileList(path, extension);
            return files.Count(file => file.EndsWith(extension, StringComparison.OrdinalIgnoreCase));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при подсчете файлов: {ex.Message}");
            return 0;
        }
    }
}


