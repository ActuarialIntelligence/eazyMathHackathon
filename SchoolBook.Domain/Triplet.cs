using SchoolBook.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Domain
{
    public class Triplet
    {
        public int index { get; private set; }
        public string name { get; private set; }
        public Func<IHomeworkParameters,string> function { get; private set; }
        public Triplet(int index,
        string name,
        Func<IHomeworkParameters,string> function)
        {
            this.index = index;
            this.name = name;
            this.function = function;
        }
    }
}
