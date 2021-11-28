using System.Collections.Generic;
using DBMS;
using Xunit;

namespace Tests {
    public class TestProjection {
        [Fact]
        private void TestProjection1() {
            var database = new Database("");
            var table = new Table("");
            var column1 = new IntColumn("C1");
            var column2 = new StringColumn("C2");
            var column3 = new CharColumn("C3");
            var row1 = new Row {
                Values = new List<string> { "1", "abc", "A" }
            };
            var row2 = new Row {
                Values = new List<string> { "42", "qq", "J" }
            };

            database.Tables.Add(table);
            database.Tables[0].Columns.Add(column1);
            database.Tables[0].Columns.Add(column2);
            database.Tables[0].Columns.Add(column3);
            database.Tables[0].Rows.Add(row1);
            database.Tables[0].Rows.Add(row2);

            var projection = new Table("") {
                Columns = new List<Column> { column1, column3 },
                Rows = new List<Row> {
                    new Row { Values = new List<string> { "1", "A" } },
                    new Row { Values = new List<string> { "42", "J" } }
                }
            };

            DatabaseManager.Instance.Database = database;
            var testProjection = DatabaseManager.Instance.Project(0, new int[] { 0, 2 });
            Assert.Equal(projection.Columns[0], testProjection.Columns[0]);
            Assert.Equal(projection.Columns[1], testProjection.Columns[1]);
            Assert.Equal(projection.Rows[0].Values[0], testProjection.Rows[0].Values[0]);
            Assert.Equal(projection.Rows[0].Values[1], testProjection.Rows[0].Values[1]);
            Assert.Equal(projection.Rows[1].Values[0], testProjection.Rows[1].Values[0]);
            Assert.Equal(projection.Rows[1].Values[1], testProjection.Rows[1].Values[1]);
        }
    }
}
