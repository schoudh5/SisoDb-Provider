using NUnit.Framework;
using SisoDb.SqlCe4.DbSchema;

namespace SisoDb.Tests.UnitTests.SqlCe4.DbSchema
{
    [TestFixture]
    public class SqlCe4DbColumnGeneratorTests : UnitTestBase
    {
        [Test]
        public void ToSql_WhenNameAndDbDataTypeIsPassed_ReturnsSqlWithNameAndType()
        {
            const string arbitraryColumnName = "TestName";
            const string arbitraryDbDataTypeName = "TestDbDataType";
            var expectedColumnDefinition = string.Format("[{0}] {1} sparse null", arbitraryColumnName, arbitraryDbDataTypeName);

            var columnGenerator = new SqlCe4DbColumnGenerator();
            var columnDefinition = columnGenerator.ToSql(arbitraryColumnName, arbitraryDbDataTypeName);

            Assert.AreEqual(expectedColumnDefinition, columnDefinition);
        }
    }
}