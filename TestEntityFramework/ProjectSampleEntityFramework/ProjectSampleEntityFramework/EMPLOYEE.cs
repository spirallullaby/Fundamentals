namespace ProjectSampleEntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYEES")]
    public partial class EMPLOYEE
    {
        public int ID { get; set; }

        [StringLength(15)]
        public string FIRSTNAME { get; set; }

        [StringLength(15)]
        public string LASTNAME { get; set; }

        public int? OCCUPATION_ID { get; set; }

        public virtual OCCUPATION OCCUPATION { get; set; }
    }
}
