using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestDataObject : IFileDataObject
{
    public List<string> GetFileList(string path, string extension)
    {
        return new List<string>
        {
            "example.txt",
            "readme.txt",
            "report.pdf",
            "data.txt"
        };
    }
}
