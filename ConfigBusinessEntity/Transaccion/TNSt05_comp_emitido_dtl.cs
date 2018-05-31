namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt05_comp_emitido_dtl
    {
        [Key]
        public long id_comp_emitido_dtl { get; set; }

        public long id_comp_emitido { get; set; }

        public long id_producto { get; set; }

        [Required]
        [StringLength(1000)]
        public string txt_producto { get; set; }

        public int? id_um { get; set; }

        public decimal cantidad { get; set; }

        public decimal? peso { get; set; }

        public decimal por_dscto { get; set; }

        public decimal mto_dscto_sin_tax { get; set; }

        public decimal mto_dscto_con_tax { get; set; }

        public decimal punit_sin_tax { get; set; }

        public decimal punit_con_tax { get; set; }

        public decimal tax_por_tot { get; set; }

        public decimal tax_mto_tot { get; set; }

        public decimal tax_por01 { get; set; }

        public decimal tax_por02 { get; set; }

        public decimal tax_por03 { get; set; }

        public decimal tax_por04 { get; set; }

        public decimal tax_por05 { get; set; }

        public decimal tax_por06 { get; set; }

        public decimal tax_por07 { get; set; }

        public decimal tax_por08 { get; set; }

        public decimal tax_mto01 { get; set; }

        public decimal tax_mto02 { get; set; }

        public decimal tax_mto03 { get; set; }

        public decimal tax_mto04 { get; set; }

        public decimal tax_mto05 { get; set; }

        public decimal tax_mto06 { get; set; }

        public decimal tax_mto07 { get; set; }

        public decimal tax_mto08 { get; set; }

        public decimal mto_vta_sin_tax { get; set; }

        public decimal mto_vta_con_tax { get; set; }

        public int? id_razon { get; set; }

        [StringLength(600)]
        public string txt_observ { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public virtual MSTt05_razon MSTt05_razon { get; set; }

        public virtual PROt09_producto PROt09_producto { get; set; }

        public virtual SNTt06_unidad_medida SNTt06_unidad_medida { get; set; }

        public virtual TNSt04_comp_emitido TNSt04_comp_emitido { get; set; }
    }
}
