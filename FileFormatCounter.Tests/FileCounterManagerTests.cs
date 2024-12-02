using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

[TestClass]
public class FileCounterManagerTests
{
    [TestMethod]
    public void CountFilesWithExtension_ValidFiles_ReturnsCorrectCount()
    {
        var testData = new TestDataObject();
        var manager = new FileCounterManager(testData);

        int result = manager.CountFilesWithExtension("dummyPath", ".txt");

        Assert.AreEqual(3, result); // В заглушке 3 файла с .txt
    }

    [TestMethod]
    public void CountFilesWithExtension_NoMatchingFiles_ReturnsZero()
    {
        var testData = new TestDataObject();
        var manager = new FileCounterManager(testData);

        int result = manager.CountFilesWithExtension("dummyPath", ".jpg");

        Assert.AreEqual(0, result); // В заглушке нет файлов с .jpg
    }

    [TestMethod]
    [ExpectedException(typeof(DirectoryNotFoundException))]
    public void CountFilesWithExtension_InvalidPath_ThrowsException()
    {
        var fileDataObject = new FileDataObject();
        var manager = new FileCounterManager(fileDataObject);

        manager.CountFilesWithExtension("invalidPath", ".txt");
    }
}

