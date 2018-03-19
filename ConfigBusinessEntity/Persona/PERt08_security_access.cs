namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERt08_security_access
    {
        [Key]
        public int id_security_access { get; set; }

        public int sn_none { get; set; }

        public int sn_full { get; set; }

        public int sn_add { get; set; }

        public int sn_upd { get; set; }

        public int sn_del { get; set; }

        public int sn_read { get; set; }

        public int id_access_item { get; set; }

        public int id_clase_emp { get; set; }

        public virtual PERt06_clase_emp PERt06_clase_emp { get; set; }

        public virtual PERt07_access_item PERt07_access_item { get; set; }
    }
}
