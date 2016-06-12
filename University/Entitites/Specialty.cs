namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specialty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specialty()
        {
            Groups = new HashSet<Group>();
        }

        public int SpecialtyID { get; set; }

        public int? DepartamentID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(50)]
        public string TrainingProgram { get; set; }

        [StringLength(20)]
        public string TrainingPeriod { get; set; }

        public virtual Departament Departament { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Groups { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
