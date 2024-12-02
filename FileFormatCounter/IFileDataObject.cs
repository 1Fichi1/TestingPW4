using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IFileDataObject
{
    List<string> GetFileList(string path, string extension);
}

