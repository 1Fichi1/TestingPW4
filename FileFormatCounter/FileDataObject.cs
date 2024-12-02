using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class FileDataObject : IFileDataObject
{
    public List<string> GetFileList(string path, string extension)
    {
        if (!Directory.Exists(path))
            throw new DirectoryNotFoundException($"Папка '{path}' не найдена.");

        return Directory.GetFiles(path, $"*{extension}").ToList();
    }
}


