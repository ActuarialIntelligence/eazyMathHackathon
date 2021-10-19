using SchoolBook.Domain.YouTube;
using SchoolBook.Infrastructure.Data;
using SchoolBook.Infrastructure.Readers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Infrastructure.Readers.DBReaders
{
    public class YouTubeClassesReader : IReader<IList<YouTube>>
    {
        private readonly SchoolBookEntities context; //
        public YouTubeClassesReader(SchoolBookEntities context)
        {
            this.context = context;
        }

        public IList<YouTube> GetData()
        {
            var links = context.YouTubeSpecifics.Where(r=>r.ID!=0).ToList();
            var listYoutube = new List<YouTube>();
            foreach(var obj in links)
            {
                var youTube = new YouTube();
                youTube.SubSyllabusID = obj.SubSyllabusID;
                youTube.ImageLink = obj.ImageLink;
                youTube.VideoLink = obj.VideoLink;
                listYoutube.Add(youTube);
            }

            return listYoutube;
            
        }
    }
}
