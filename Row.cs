using System.Collections.Generic;

namespace DBMS {
    public class Row {
        public List<object> Values { get; set; }

        public object this[int i] {
            get => Values[i];
            set => Values[i] = value;
        }
    }
}
