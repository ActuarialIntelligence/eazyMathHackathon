using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Writers.Interfaces
{
    public interface IDataWriter<P> where P : class
    {
        void WriteData(P entity);
    }

    public interface IWriter<P> 
    {
        void WriteData(P value,int id);
    }
}
