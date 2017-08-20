namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt08_funciones_vitales
    {
        [Key]
        public long id_funciones_vitales { get; set; }

        [StringLength(10)]
        public string cod_funciones_vitales { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fec_negocio { get; set; }

        [StringLength(10)]
        public string fec_registro { get; set; }

        [StringLength(50)]
        public string sistoles { get; set; }

        [StringLength(50)]
        public string diastoles { get; set; }

        [StringLength(50)]
        public string pulsaciones { get; set; }

        [StringLength(50)]
        public string ritmo_respiratorio { get; set; }

        [StringLength(50)]
        public string temperatura { get; set; }

        [StringLength(50)]
        public string altura { get; set; }

        [StringLength(50)]
        public string peso { get; set; }

        [StringLength(50)]
        public string imc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public long id_atencion { get; set; }

        public virtual CLIt03_atencion CLIt03_atencion { get; set; }
    }
}
