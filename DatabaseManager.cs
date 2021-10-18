using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DBMS {
    public class DatabaseManager {
        private const string _specialChars = "\\/:*?\"<>|";
        private Database _database;
        private static DatabaseManager _instance;
        
        public static DatabaseManager Instance {
            get {
                if (_instance == null) {
                    _instance = new DatabaseManager();
                }

                return _instance;
            }
        }

        private DatabaseManager() { }

        #region Database methods
        public bool CreateDatabase(string name) {
            if (name.IndexOfAny(_specialChars.ToCharArray()) != -1) {
                return false;
            }

            _database = new Database(name);
            return true;
        }

        public bool SaveDatabase(string path) {
            try {
                var streamWriter = new StreamWriter(path);

                streamWriter.WriteLine(_database.Name);
                WriteTablesToFile(streamWriter);
                streamWriter.Close();
                return true;
            }
            catch {
                return false;
            }
        }

        public bool OpenDatabase(string path) {
            try {
                var streamReader = new StreamReader(path);
                string file = streamReader.ReadToEnd();
                string[] parts = file.Split('$');
                _database = new Database(parts[0]);

                ReadTablesFromFile(parts);
                streamReader.Close();

                return true;
            }
            catch {
                return false;
            }
        }

        public bool DeleteDatabase(string path) {
            try {
                _database = null;
                File.Delete(path);

                return true;
            }
            catch {
                return false;
            }
        }
        #endregion

        #region Table methods
        public bool AddTable(string name) {
            if (name.Equals("") || _database == null) {
                return false;
            }

            _database.Tables.Add(new Table(name));
            return true;
        }

        public Table GetTable(int index) => _database.Tables[index];

        public List<string> GetTableNames() => _database.Tables.Select(t => t.Name).ToList();

        public void DeleteTable(int index) {
            _database.Tables.RemoveAt(index);
        }
        #endregion

        #region Column methods
        public bool AddColumn(int tableIndex, Column column) {
            if (_database == null || _database.Tables.Count == 0) {
                return false;
            }

            _database.Tables[tableIndex].Columns.Add(column);

            foreach (var row in _database.Tables[tableIndex].Rows) {
                row.Values.Add("");
            }

            return true;
        }

        public void DeleteColumn(int tableIndex, int columnIndex) {
            _database.Tables[tableIndex].Columns.RemoveAt(columnIndex);

            foreach (var row in _database.Tables[tableIndex].Rows) {
                row.Values.RemoveAt(columnIndex);
            }
        }
        #endregion

        #region Row methods
        public bool AddRow(int tableIndex) {
            if (_database == null || _database.Tables.Count == 0 || _database.Tables[tableIndex].Columns.Count == 0) {
                return false;
            }

            var row = new Row();
            
            foreach (var _ in _database.Tables[tableIndex].Columns) {
                row.Values.Add("");
            }
            
            _database.Tables[tableIndex].Rows.Add(row);
            
            return true;
        }

        public void DeleteRow(int tableIndex, int rowIndex) {
            _database.Tables[tableIndex].Rows.RemoveAt(rowIndex);
        }
        #endregion

        #region Extra operations
        public bool ChangeCellValue(string newValue, int tableIndex, int columnIndex, int rowIndex) {
            if (_database.Tables[tableIndex].Columns[columnIndex].Validate(newValue)) {
                _database.Tables[tableIndex].Rows[rowIndex].Values[columnIndex] = newValue;

                return true;
            }
            
            return false;
        }

        public List<Row> Project(int tableIndex, int[] columnIndices) {
            if (_database == null || _database.Tables.Count == 0 || _database.Tables[tableIndex].Columns.Count == 0) {
                return null;
            }

            var resList = new List<Row>();

            foreach (var row in _database.Tables[tableIndex].Rows) {
                var resRow = new Row();
                
                foreach (int i in columnIndices) {
                    resRow.Values.Add(row.Values[i]);
                }

                resList.Add(resRow);
            }

            return resList;
        }
        #endregion

        #region Inner methods
        private void ReadTablesFromFile(string[] parts) {
            for (int i = 1; i < parts.Length; i++) {
                parts[i] = parts[i].Replace("\r\n", "\r");
                var buf = parts[i].Split('\r').ToList();

                buf.RemoveAt(0);
                buf.RemoveAt(buf.Count - 1);

                if (buf.Count > 0) {
                    _database.Tables.Add(new Table(buf[0]));
                }

                if (buf.Count > 2) {
                    ReadColumnsFromFile(parts, buf, i);
                    ReadRowsFromFile(buf, i);
                }
            }
        }

        private void ReadColumnsFromFile(string[] parts, List<string> buf, int tableIndex) {
            string[] columnNames = buf[1].Split('\t');
            string[] columnTypes = buf[1].Split('\t');

            for (int j = 0; j < columnNames.Length - 1; j++) {
                _database.Tables[tableIndex - 1].Columns.Add(ColumnFromString(columnNames[j], columnTypes[j]));
            }
        }

        private void ReadRowsFromFile(List<string> buf, int tableIndex) {
            for (int j = 3; j < buf.Count; j++) {
                _database.Tables[tableIndex - 1].Rows.Add(new Row());

                var values = buf[j].Split('\t').ToList();
                values.RemoveAt(values.Count - 1);
                _database.Tables[tableIndex - 1].Rows.Last().Values.AddRange(values);
            }
        }

        private void WriteTablesToFile(StreamWriter streamWriter) {
            foreach (var table in _database.Tables) {
                streamWriter.WriteLine('$');
                streamWriter.WriteLine(table.Name);

                WriteColumnsToFile(streamWriter, table);
                WriteRowsToFile(streamWriter, table);
            }
        }

        private static void WriteColumnsToFile(StreamWriter streamWriter, Table table) {
            foreach (var column in table.Columns) {
                streamWriter.Write(column.Name + '\t');
            }

            streamWriter.WriteLine();

            foreach (var column in table.Columns) {
                streamWriter.Write(column.type + '\t');
            }

            streamWriter.WriteLine();
        }

        private static void WriteRowsToFile(StreamWriter streamWriter, Table table) {
            foreach (var row in table.Rows) {
                foreach (var value in row.Values) {
                    streamWriter.Write(value.ToString() + '\t');
                }
            }
        }

        public static Column ColumnFromString(string name, string type) {
            return type switch {
                "INT" => new IntColumn(name),
                "REAL" => new RealColumn(name),
                "CHAR" => new CharColumn(name),
                "STRING" => new StringColumn(name),
                "TEXT FILE" => new TextFileColumn(name),
                "INT INTERVAL" => new IntIntervalColumn(name),
                _ => null,
            };
        }
        #endregion
    }
}
