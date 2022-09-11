using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Module16._6._2.Tests
{
    [TestFixture]
    public class FileWorkerTests
    {
        [Test]
        public void GetSafeFilename_MustReturnCorrectValue()
        {
            var fileWorker = new FileWorker();
            PrivateObject privateObject = new PrivateObject(fileWorker);
            var privateFunction = privateObject.Invoke("GetSafeFilename", @"Folder:?<>*/\_Name:");
            NUnit.Framework.Assert.AreEqual(privateFunction, "Folder________Name_");
        }
    }
}
