namespace WebApplication16.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BOOKS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOOKS()
        {
            INTERTABLE = new HashSet<INTERTABLE>();
        }

        [Key]
        public int BOOKID { get; set; }

        [Required]
        [StringLength(30)]
        public  string BOOKNAME { get; set; }

        [Required]
        [StringLength(30)]
        public  string AUTHOR { get; set; }

        public  int ISBN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INTERTABLE> INTERTABLE { get; set; }
    }
}
