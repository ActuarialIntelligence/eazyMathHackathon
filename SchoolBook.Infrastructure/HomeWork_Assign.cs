//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolBook.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class HomeWork_Assign
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HomeWork_Assign()
        {
            this.HomeWork = new HashSet<HomeWork>();
            this.HomeWorkParametersStudentPairings = new HashSet<HomeWorkParametersStudentPairing>();
        }
    
        public int SubSyllabusID { get; set; }
        public int NoOfQuestions { get; set; }
        public int HomeWorkID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HomeWork> HomeWork { get; set; }
        public virtual SubSyllabu SubSyllabu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HomeWorkParametersStudentPairing> HomeWorkParametersStudentPairings { get; set; }
    }
}
