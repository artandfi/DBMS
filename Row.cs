using System.Collections.Generic;

namespace DBMS {
    public class Row {
        public List<string> Values { get; set; }

        public string this[int i] {
            get => Values[i];
            set => Values[i] = value;
        }
    }
}
