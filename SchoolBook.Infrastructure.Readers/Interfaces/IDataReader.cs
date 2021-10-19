using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Readers.Interfaces
{
    public interface IDatedDataReader<P>
    {
        P GetData(int id,DateTime date);
    }
    public interface IDataReader<P> 
    {
        P GetData(int id);
    }

    public interface IDateGradeParametricDataReader<P> where P : class
    {
        P GetData(DateTime date,int gradeId);
    }

    public interface IReader<P> where P : class
    {
        P GetData();
    }
}
