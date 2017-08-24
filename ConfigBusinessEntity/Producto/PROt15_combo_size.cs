namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt15_combo_size
    {
        [Key]
        public long id_combo_size { get; set; }

        [StringLength(10)]
        public string cod_combo_size { get; set; }

        public decimal cantidad { get; set; }

        public decimal mto_pvpu_sin_tax { get; set; }

        public decimal mto_pvpu_con_tax { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public long id_combo_dtl { get; set; }

        public long id_producto { get; set; }

        public virtual PROt09_producto PROt09_producto { get; set; }

        public virtual PROt14_combo_dtl PROt14_combo_dtl { get; set; }
    }
}
