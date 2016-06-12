namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Progress")]
    public partial class Progress
    {
        public int ProgressID { get; set; }

        public int? SubjectID { get; set; }

        public int? StudentID { get; set; }

        [StringLength(20)]
        public string Semester { get; set; }

        public int? Mark { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Student Student { get; set; }
    }
}
