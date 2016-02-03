namespace WebApplication16.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INTERTABLE")]
    public partial class INTERTABLE
    {
        public int? CATID { get; set; }

        public int BOOKID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDENT { get; set; }

        public virtual BOOKS BOOKS { get; set; }

        public virtual CATEGORIES CATEGORIES { get; set; }
    }
}
