using System.Collections.Generic;

namespace DBMS {
    public class Table {
        public string Name { get; set; }
        public List<Row> Rows { get; set; }
        public List<Column> Columns { get; set; }
    }
}
