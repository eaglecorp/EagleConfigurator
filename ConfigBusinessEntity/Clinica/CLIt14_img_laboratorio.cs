namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt14_img_laboratorio
    {
        [Key]
        public long id_img_laboratorio { get; set; }

        [StringLength(10)]
        public string cod_img_laboratorio { get; set; }

        public long? id_laboratorio { get; set; }

        [StringLength(350)]
        public string txt_path { get; set; }

        [StringLength(5000)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public virtual CLIt13_laboratorio CLIt13_laboratorio { get; set; }
    }
}
