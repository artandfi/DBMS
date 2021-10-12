using System.IO;

namespace DBMS {
    public abstract class Column {
        public const string type = "";
        public string Name { get; set; }

        public abstract bool Validate(string value);
    }

    public class IntColumn : Column {
        public new const string type = "int";

        public override bool Validate(string value) => int.TryParse(value, out _);
    }

    public class RealColumn : Column {
        public new const string type = "real";

        public override bool Validate(string value) => double.TryParse(value, out _);
    }

    public class CharColumn : Column {
        public new const string type = "char";

        public override bool Validate(string value) => char.TryParse(value, out _);
    }

    public class StringColumn : Column {
        public new const string type = "string";

        public override bool Validate(string value) => true;
    }

    public class TextFileColumn : Column {
        public new const string type = "text file";

        public override bool Validate(string value) => value.ToLower().EndsWith(".txt") && File.Exists(value);
    }

    public class IntIntervalColumn : Column {
        public new const string type = "int interval";

        public override bool Validate(string value) {
            string[] buf = value.Replace(" ", "").Split(',');

            return buf.Length == 2 && int.TryParse(buf[0], out int a) && int.TryParse(buf[1], out int b) && a < b;
        }
    }
}
