using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS {
    public class Row {
        public List<object> Values { get; set; }

        public object this[int i] {
            get => Values[i];
            set => Values[i] = value;
        }
    }
}
