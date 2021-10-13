using System.Collections.Generic;

namespace DBMS {
    class Database {
        public string Name { get; set; }
        public List<Table> Tables { get; set; }

        public Database(string name) {
            Name = name;
        }
    }
}
