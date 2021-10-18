using System.IO;

namespace DBMS {
    public abstract class Column {
        public readonly string type = "";
        public string Name { get; set; }

        public Column(string name) {
            Name = name;
        }

        public abstract bool Validate(string value);
    }

    public class IntColumn : Column {
        public new readonly string type = "INT";
        public IntColumn(string name) : base(name) { }

        public override bool Validate(string value) => int.TryParse(value, out _);
    }

    public class RealColumn : Column {
        public new readonly string type = "REAL";
        public RealColumn(string name) : base(name) { }

        public override bool Validate(string value) => double.TryParse(value, out _);
    }

    public class CharColumn : Column {
        public new readonly string type = "CHAR";
        public CharColumn(string name) : base(name) { }

        public override bool Validate(string value) => char.TryParse(value, out _);
    }

    public class StringColumn : Column {
        public new readonly string type = "STRING";
        public StringColumn(string name) : base(name) { }

        public override bool Validate(string value) => true;
    }

    public class TextFileColumn : Column {
        public new readonly string type = "TEXT FILE";
        public TextFileColumn(string name) : base(name) { }

        public override bool Validate(string value) => value.ToLower().EndsWith(".txt") && File.Exists(value);
    }

    public class IntIntervalColumn : Column {
        public new readonly string type = "INT INTERVAL";
        public IntIntervalColumn(string name) : base(name) { }

        public override bool Validate(string value) {
            string[] buf = value.Replace(" ", "").Split(',');

            return buf.Length == 2 && int.TryParse(buf[0], out int a) && int.TryParse(buf[1], out int b) && a < b;
        }
    }
}
