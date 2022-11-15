using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalaizerClassLibrary.Tests
{
    [TestClass]
    public class AnalaizerClassTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"D:\danylo\Ed\University\3 курс\Тести\Lab N1\Calculator\TestData.xml", "data", DataAccessMethod.Sequential)]
        [TestMethod]
        public void CreateStack_FromDataSourceTest()
        {
            // Arrange
            string initial = (string)TestContext.DataRow["initial"];
            string expected = (string)TestContext.DataRow["expected"];
            AnalaizerClass.expression = initial;

            // Actual
            string actual = string.Join("", AnalaizerClass.CreateStack().ToArray());

            // Assert
            Assert.AreEqual(expected, actual);  
        }
    }
}