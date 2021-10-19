using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Domain
{
    public class Pair<Key,Value>
    {
        public Pair(Key key, Value value)
        {
            GetKey = key;
            GetValue = value;
        }
        public Key GetKey { get; private set; } 
        public Value GetValue { get; private set; }
    }
}
