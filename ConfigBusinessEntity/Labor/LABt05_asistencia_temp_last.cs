namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABt05_asistencia_temp_last
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_asistencia_temp_last { get; set; }

        public long id_empleado { get; set; }

        public long id_asistencia { get; set; }
    }
}
