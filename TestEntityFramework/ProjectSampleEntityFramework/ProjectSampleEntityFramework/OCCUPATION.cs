namespace ProjectSampleEntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OCCUPATIONS")]
    public partial class OCCUPATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OCCUPATION()
        {
            EMPLOYEES = new HashSet<EMPLOYEE>();
        }

        [Key]
        public int OCCUPATION_ID { get; set; }

        [StringLength(10)]
        public string OCCUPATION_NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEE> EMPLOYEES { get; set; }
    }
}
