namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt11_receta_dtl
    {
        [Key]
        public long id_receta_dtl { get; set; }

        public long? id_producto { get; set; }

        [StringLength(250)]
        public string txt_producto { get; set; }

        public decimal? peso { get; set; }

        public decimal? cantidad { get; set; }

        public int id_um { get; set; }

        public long id_receta { get; set; }

        public virtual PROt09_producto PROt09_producto { get; set; }

        public virtual PROt10_receta PROt10_receta { get; set; }

        public virtual SNTt06_unidad_medida SNTt06_unidad_medida { get; set; }
    }
}
