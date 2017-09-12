namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt16_combo_variable_dtl
    {
        [Key]
        public long id_combo_variable_dtl { get; set; }

        [StringLength(50)]
        public string cod_combo_variable_dtl { get; set; }

        public decimal cantidad { get; set; }

        public decimal mto_pvpu_sin_tax { get; set; }

        public decimal mto_pvpu_con_tax { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public long id_combo_variable { get; set; }

        public long id_producto { get; set; }

        public virtual PROt09_producto PROt09_producto { get; set; }

        public virtual PROt15_combo_variable PROt15_combo_variable { get; set; }
    }
}
