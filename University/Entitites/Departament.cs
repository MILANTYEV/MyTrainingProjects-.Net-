namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Departament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departament()
        {
            Specialties = new HashSet<Specialty>();
        }

        public int DepartamentID { get; set; }

        public int? FacultyID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(50)]
        public string DepartamentHead { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public virtual Faculty Faculty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specialty> Specialties { get; set; }
    }
}
