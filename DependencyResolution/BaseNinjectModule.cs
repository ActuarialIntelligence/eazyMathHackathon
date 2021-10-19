using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using SchoolBook.Logic.Interfaces;
using SchoolBook.Logic;
using SchoolBook.Infrastructure.Readers;
using SchoolBook.Infrastructure.Readers.Interfaces;
using SchoolBook.Domain.HomeWork;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Writers;
using SchoolBook.Infrastructure.Writers.Interfaces;
using SchoolBook.Infrastructure.Data.Dto;
using SchoolBook.Infrastructure.Readers.DBReaders;
using SchoolBook.Domain.YouTube;
using SchoolBook.Domain.StudentTeacher;
using SchoolBook.Domain;

namespace SchoolBook.DependencyResolution
{
    public class BaseNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDataReader<HomeWorkAssign>>().To<HomeWorkAssignmentReader>()
                .Named("HomeWorkAssignmentReader");

            Bind<IDataWriter<SchoolBook.Domain.HomeWork.HomeWork>>().To<HomeworkQuestionsWriter>()
                 .Named("HomeworkQuestionsWriter");

            Bind<IReader<IList<YouTube>>>().To<YouTubeClassesReader>();

            Bind<IWriter<string>>().To<AnswersWriter>();

            Bind<IDateGradeParametricDataReader<IList<SchoolBook.Domain.HomeWork.HomeWork>>>().To<HomeWorksReader>();

            Bind<IDataWriter<SchoolBook.Domain.HomeWork.HomeWork>>().To<MarksUpdater>().Named("MarksUpdater");

            Bind<IDataWriter<Student>>().To<StudentWriter>();
            Bind<IDataWriter<Tutor>>().To<TutorWriter>();

            Bind < IDataReader<IList<Student>>>().To<StudentsByTutorIDReader>().Named("StudentsByTutorIDReader");
            Bind<IDataWriter<IList<StudentTeacherRelationship>>>().To<StudentTeacherPairingWritercs>();
            Bind<IDataReader<IList<Student>>>().To<StudentsByPlaceNotPairedWithTutorReader>().Named("StudentsByPlaceReader");

            Bind<IDataReader<int>>().To<HWByStudentReader>();
            Bind<IDataReader<IList<SubSyllabus>>>().To<SubSyllabusReader>();
            Bind<IDataWriter<HomeWorkAssign>>().To<HomeWorkAssignWriter>();

             Bind<SchoolBookEntities>().ToSelf();

        }
    }
}
