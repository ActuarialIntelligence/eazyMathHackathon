using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.ViewModels
{
    public class YouTubeWrapperViewModel
    {
        public IList<YouTubeViewModel> YouTubeModels { get; set; }

        public IList<int> GetSubSyllabusIDs
        {
            get
            {
                var list = new List<int>();
                var distinct = YouTubeModels.Select(s => s.SubSyllabusID).Distinct();
                foreach(int t in distinct)
                {
                    list.Add(t);
                }

                return list;
            }
        }
    }
}