using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    //Value type Data Type KeyValue
    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }

}
