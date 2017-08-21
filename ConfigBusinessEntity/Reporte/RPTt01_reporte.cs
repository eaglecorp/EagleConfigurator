namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RPTt01_reporte
    {
        [Key]
        public int id_reporte { get; set; }

        [StringLength(10)]
        public string cod_reporte { get; set; }

        [Required]
        [StringLength(150)]
        public string txt_desc { get; set; }

        public bool sn_date_range { get; set; }

        public bool sn_rvc_range { get; set; }

        public bool sn_number_range { get; set; }

        [StringLength(260)]
        public string txt_path { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public int id_categoria_reporte { get; set; }

        public virtual RPTt02_categoria_reporte RPTt02_categoria_reporte { get; set; }
    }
}
