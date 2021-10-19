using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SchoolBookMVC.ViewModels
{
    public class TickObject
    {
        [DisplayName("Incorrect")]
        public bool Incorrect { get; set; }

        [DisplayName("Correct")]
        public bool Correct { get; set; }
    }
}

//@model MyViewModel
//@using(Html.BeginForm())
//{
//    @Html.Label("Your choice")

//    @Html.LabelFor(model => model.Option1) // here the 'LabelFor' will show you the name you set with DisplayName attribute
//    @Html.CheckBoxFor(model => model.Option1)

//    @Html.LabelFor(model => model.Option2)
//    @Html.CheckBoxFor(model => model.Option2)
//    < p >
//        < input type = "submit" value = "Submit" />
   
//       </ p >
//}