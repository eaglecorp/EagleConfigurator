namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt05_antece_alergia
    {
        [Key]
        public long id_antece_alergia { get; set; }

        [StringLength(10)]
        public string cod_antece_alergia { get; set; }

        public long? id_paciente { get; set; }

        [StringLength(4000)]
        public string txt_antecedentes { get; set; }

        [StringLength(4000)]
        public string txt_alergias { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public virtual CLIt01_paciente CLIt01_paciente { get; set; }
    }
}
