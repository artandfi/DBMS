using System.IO;

namespace DBMS {
    public abstract class Column {
        public string type = "";
        
        public string Name { get; set; }

        public abstract bool Validate(string value);

        public Column(string name) {
            Name = name;
        }
    }

    public class IntColumn : Column {
        public new string type = "int";

        public override bool Validate(string value) => int.TryParse(value, out _);

        public IntColumn(string name) : base(name) { }
    }

    public class RealColumn : Column {
        public new string type = "real";

        public override bool Validate(string value) => double.TryParse(value, out _);

        public RealColumn(string name) : base(name) { }
    }

    public class CharColumn : Column {
        public new string type = "char";

        public override bool Validate(string value) => char.TryParse(value, out _);

        public CharColumn(string name) : base(name) { }
    }

    public class StringColumn : Column {
        public new string type = "string";

        public override bool Validate(string value) => true;

        public StringColumn(string name) : base(name) { }
    }

    public class TextFileColumn : Column {
        public new string type = "text file";

        public override bool Validate(string value) => value.ToLower().EndsWith(".txt") && File.Exists(value);

        public TextFileColumn(string name) : base(name) { }
    }

    public class IntIntervalColumn : Column {
        public new string type = "int interval";

        public override bool Validate(string value) {
            string[] buf = value.Replace(" ", "").Split(',');

            return buf.Length == 2 && int.TryParse(buf[0], out int a) && int.TryParse(buf[1], out int b) && a < b;
        }

        public IntIntervalColumn(string name) : base(name) { }
    }
}
