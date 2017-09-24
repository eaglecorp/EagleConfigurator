namespace ConfigBusinessEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EagleContext : DbContext
    {

        public EagleContext(string connectionString)
            : base(connectionString)
        {
        }



        public virtual DbSet<CLIt01_paciente> CLIt01_paciente { get; set; }
        public virtual DbSet<CLIt02_actividad> CLIt02_actividad { get; set; }
        public virtual DbSet<CLIt03_atencion> CLIt03_atencion { get; set; }
        public virtual DbSet<CLIt04_atencion_dtl> CLIt04_atencion_dtl { get; set; }
        public virtual DbSet<CLIt05_antece_alergia> CLIt05_antece_alergia { get; set; }
        public virtual DbSet<CLIt06_tipo_especialidad> CLIt06_tipo_especialidad { get; set; }
        public virtual DbSet<CLIt07_especialidad_medica> CLIt07_especialidad_medica { get; set; }
        public virtual DbSet<CLIt08_funciones_vitales> CLIt08_funciones_vitales { get; set; }
        public virtual DbSet<CLIt09_anamnesis> CLIt09_anamnesis { get; set; }
        public virtual DbSet<CLIt10_examen_fisico> CLIt10_examen_fisico { get; set; }
        public virtual DbSet<CLIt11_estudio_complementario> CLIt11_estudio_complementario { get; set; }
        public virtual DbSet<CLIt12_archivo_complementario> CLIt12_archivo_complementario { get; set; }
        public virtual DbSet<CLIt13_laboratorio> CLIt13_laboratorio { get; set; }
        public virtual DbSet<CLIt14_img_laboratorio> CLIt14_img_laboratorio { get; set; }
        public virtual DbSet<CLIt15_diagnostico> CLIt15_diagnostico { get; set; }
        public virtual DbSet<CLIt16_cie10> CLIt16_cie10 { get; set; }
        public virtual DbSet<CLIt17_tratamiento> CLIt17_tratamiento { get; set; }
        public virtual DbSet<CLIt18_evolucion> CLIt18_evolucion { get; set; }
        public virtual DbSet<CLIt19_cita> CLIt19_cita { get; set; }
        public virtual DbSet<CSHt01_caja_dtl> CSHt01_caja_dtl { get; set; }
        public virtual DbSet<FISt01_control_numeracion> FISt01_control_numeracion { get; set; }
        public virtual DbSet<FISt02_nivel> FISt02_nivel { get; set; }
        public virtual DbSet<FISt03_tipo_numeracion> FISt03_tipo_numeracion { get; set; }
        public virtual DbSet<GRLt01_parametro> GRLt01_parametro { get; set; }
        public virtual DbSet<GRLt02_estado> GRLt02_estado { get; set; }
        public virtual DbSet<GRLt03_horario> GRLt03_horario { get; set; }
        public virtual DbSet<GRLt04_configuracion_caja> GRLt04_configuracion_caja { get; set; }
        public virtual DbSet<MSTt01_medio_pago> MSTt01_medio_pago { get; set; }
        public virtual DbSet<MSTt02_descuento> MSTt02_descuento { get; set; }
        public virtual DbSet<MSTt03_tipo_orden> MSTt03_tipo_orden { get; set; }
        public virtual DbSet<MSTt04_canal_vta> MSTt04_canal_vta { get; set; }
        public virtual DbSet<MSTt05_razon> MSTt05_razon { get; set; }
        public virtual DbSet<MSTt06_impuesto> MSTt06_impuesto { get; set; }
        public virtual DbSet<MSTt07_estado_civil> MSTt07_estado_civil { get; set; }
        public virtual DbSet<MSTt08_location> MSTt08_location { get; set; }
        public virtual DbSet<MSTt09_tipo_location> MSTt09_tipo_location { get; set; }
        public virtual DbSet<MSTt10_impresora> MSTt10_impresora { get; set; }
        public virtual DbSet<MSTt11_tipo_impresora> MSTt11_tipo_impresora { get; set; }
        public virtual DbSet<MSTt12_caja> MSTt12_caja { get; set; }
        public virtual DbSet<MSTt13_turno> MSTt13_turno { get; set; }
        public virtual DbSet<MSTt14_mesa> MSTt14_mesa { get; set; }
        public virtual DbSet<MSTt15_estado_mesa> MSTt15_estado_mesa { get; set; }
        public virtual DbSet<PERt01_usuario> PERt01_usuario { get; set; }
        public virtual DbSet<PERt02_cliente> PERt02_cliente { get; set; }
        public virtual DbSet<PERt03_proveedor> PERt03_proveedor { get; set; }
        public virtual DbSet<PERt04_empleado> PERt04_empleado { get; set; }
        public virtual DbSet<PERt05_categoria_emp> PERt05_categoria_emp { get; set; }
        public virtual DbSet<PERt06_clase_emp> PERt06_clase_emp { get; set; }
        public virtual DbSet<PROt01_marca> PROt01_marca { get; set; }
        public virtual DbSet<PROt02_modelo> PROt02_modelo { get; set; }
        public virtual DbSet<PROt03_familia> PROt03_familia { get; set; }
        public virtual DbSet<PROt04_subfamilia> PROt04_subfamilia { get; set; }
        public virtual DbSet<PROt05_grupo_prod> PROt05_grupo_prod { get; set; }
        public virtual DbSet<PROt06_clase_prod> PROt06_clase_prod { get; set; }
        public virtual DbSet<PROt07_tipo_prod> PROt07_tipo_prod { get; set; }
        public virtual DbSet<PROt08_precio_prod> PROt08_precio_prod { get; set; }
        public virtual DbSet<PROt09_producto> PROt09_producto { get; set; }
        public virtual DbSet<PROt10_receta> PROt10_receta { get; set; }
        public virtual DbSet<PROt11_receta_dtl> PROt11_receta_dtl { get; set; }
        public virtual DbSet<PROt12_receta_grupo> PROt12_receta_grupo { get; set; }
        public virtual DbSet<PROt13_combo> PROt13_combo { get; set; }
        public virtual DbSet<PROt14_combo_fixed_dtl> PROt14_combo_fixed_dtl { get; set; }
        public virtual DbSet<PROt15_combo_variable> PROt15_combo_variable { get; set; }
        public virtual DbSet<PROt16_combo_variable_dtl> PROt16_combo_variable_dtl { get; set; }
        public virtual DbSet<PROt17_combo_grupo> PROt17_combo_grupo { get; set; }
        public virtual DbSet<RPTt01_reporte> RPTt01_reporte { get; set; }
        public virtual DbSet<RPTt02_categoria_reporte> RPTt02_categoria_reporte { get; set; }
        public virtual DbSet<SNTt01_tipo_medio_pago> SNTt01_tipo_medio_pago { get; set; }
        public virtual DbSet<SNTt02_tipo_doc_identidad> SNTt02_tipo_doc_identidad { get; set; }
        public virtual DbSet<SNTt03_entidad_financiera> SNTt03_entidad_financiera { get; set; }
        public virtual DbSet<SNTt04_tipo_moneda> SNTt04_tipo_moneda { get; set; }
        public virtual DbSet<SNTt05_tipo_existencia> SNTt05_tipo_existencia { get; set; }
        public virtual DbSet<SNTt06_unidad_medida> SNTt06_unidad_medida { get; set; }
        public virtual DbSet<SNTt07_tipo_intangible> SNTt07_tipo_intangible { get; set; }
        public virtual DbSet<SNTt08_codigo_libro> SNTt08_codigo_libro { get; set; }
        public virtual DbSet<SNTt09_cta_contable> SNTt09_cta_contable { get; set; }
        public virtual DbSet<SNTt10_tipo_comprobante> SNTt10_tipo_comprobante { get; set; }
        public virtual DbSet<SNTt11_aduana> SNTt11_aduana { get; set; }
        public virtual DbSet<SNTt12_tipo_operacion> SNTt12_tipo_operacion { get; set; }
        public virtual DbSet<SNTt13_tipo_actividad> SNTt13_tipo_actividad { get; set; }
        public virtual DbSet<SNTt14_nacionalidad> SNTt14_nacionalidad { get; set; }
        public virtual DbSet<SNTt15_via> SNTt15_via { get; set; }
        public virtual DbSet<SNTt16_zona> SNTt16_zona { get; set; }
        public virtual DbSet<SNTt17_tipo_trabajador> SNTt17_tipo_trabajador { get; set; }
        public virtual DbSet<SNTt18_situacion_educativa> SNTt18_situacion_educativa { get; set; }
        public virtual DbSet<SNTt19_ocupacion> SNTt19_ocupacion { get; set; }
        public virtual DbSet<SNTt20_regimen_pensionario> SNTt20_regimen_pensionario { get; set; }
        public virtual DbSet<SNTt21_condicion_laboral> SNTt21_condicion_laboral { get; set; }
        public virtual DbSet<SNTt22_periodo_remuneracion> SNTt22_periodo_remuneracion { get; set; }
        public virtual DbSet<SNTt23_salud_eps> SNTt23_salud_eps { get; set; }
        public virtual DbSet<SNTt24_situacion> SNTt24_situacion { get; set; }
        public virtual DbSet<SNTt25_motivo_baja> SNTt25_motivo_baja { get; set; }
        public virtual DbSet<SNTt26_modalidad_formativa> SNTt26_modalidad_formativa { get; set; }
        public virtual DbSet<SNTt27_vinculo_familiar> SNTt27_vinculo_familiar { get; set; }
        public virtual DbSet<SNTt28_suspencion_laboral> SNTt28_suspencion_laboral { get; set; }
        public virtual DbSet<SNTt29_regimen_salud> SNTt29_regimen_salud { get; set; }
        public virtual DbSet<SNTt30_regimen_laboral> SNTt30_regimen_laboral { get; set; }
        public virtual DbSet<SNTt31_departamento> SNTt31_departamento { get; set; }
        public virtual DbSet<SNTt32_provincia> SNTt32_provincia { get; set; }
        public virtual DbSet<SNTt33_distrito> SNTt33_distrito { get; set; }
        public virtual DbSet<TNSt01_comp_recibido> TNSt01_comp_recibido { get; set; }
        public virtual DbSet<TNSt02_comp_recibido_dtl> TNSt02_comp_recibido_dtl { get; set; }
        public virtual DbSet<TNSt03_comp_recibido_estado> TNSt03_comp_recibido_estado { get; set; }
        public virtual DbSet<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }
        public virtual DbSet<TNSt05_comp_emitido_dtl> TNSt05_comp_emitido_dtl { get; set; }
        public virtual DbSet<TNSt06_comp_emitido_estado> TNSt06_comp_emitido_estado { get; set; }
        public virtual DbSet<TNSt07_medio_pago_dtl> TNSt07_medio_pago_dtl { get; set; }
        public virtual DbSet<TNSt08_descuento_dtl> TNSt08_descuento_dtl { get; set; }
        public virtual DbSet<TOTt01_total_diario_vta> TOTt01_total_diario_vta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIt01_paciente>()
                .Property(e => e.cod_paciente)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt01_paciente>()
                .Property(e => e.nro_hist_clinica)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt01_paciente>()
                .Property(e => e.grupo_sanguineo)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt01_paciente>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt01_paciente>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt01_paciente>()
                .HasMany(e => e.CLIt03_atencion)
                .WithRequired(e => e.CLIt01_paciente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIt01_paciente>()
                .HasMany(e => e.CLIt19_cita)
                .WithRequired(e => e.CLIt01_paciente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIt02_actividad>()
                .Property(e => e.cod_actividad)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt02_actividad>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt02_actividad>()
                .Property(e => e.txt_observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt02_actividad>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt03_atencion>()
                .Property(e => e.cod_atencion)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt03_atencion>()
                .Property(e => e.txt_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt03_atencion>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt03_atencion>()
                .HasMany(e => e.CLIt08_funciones_vitales)
                .WithRequired(e => e.CLIt03_atencion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIt03_atencion>()
                .HasMany(e => e.CLIt09_anamnesis)
                .WithRequired(e => e.CLIt03_atencion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIt03_atencion>()
                .HasMany(e => e.CLIt10_examen_fisico)
                .WithRequired(e => e.CLIt03_atencion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIt03_atencion>()
                .HasMany(e => e.CLIt17_tratamiento)
                .WithRequired(e => e.CLIt03_atencion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIt03_atencion>()
                .HasMany(e => e.CLIt18_evolucion)
                .WithRequired(e => e.CLIt03_atencion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIt04_atencion_dtl>()
                .Property(e => e.cod_atencion_dtl)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt04_atencion_dtl>()
                .Property(e => e.txt_observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt04_atencion_dtl>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt05_antece_alergia>()
                .Property(e => e.cod_antece_alergia)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt05_antece_alergia>()
                .Property(e => e.txt_antecedentes)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt05_antece_alergia>()
                .Property(e => e.txt_alergias)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt05_antece_alergia>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt06_tipo_especialidad>()
                .Property(e => e.cod_tipo_especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt06_tipo_especialidad>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt06_tipo_especialidad>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt07_especialidad_medica>()
                .Property(e => e.cod_especialidad_medica)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt07_especialidad_medica>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt07_especialidad_medica>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.cod_funciones_vitales)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.fec_registro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.sistoles)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.diastoles)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.pulsaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.ritmo_respiratorio)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.temperatura)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.altura)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.peso)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.imc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt08_funciones_vitales>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt09_anamnesis>()
                .Property(e => e.cod_anamnesis)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt09_anamnesis>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt09_anamnesis>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt10_examen_fisico>()
                .Property(e => e.cod_examen_fisico)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt10_examen_fisico>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt10_examen_fisico>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt11_estudio_complementario>()
                .Property(e => e.cod_estudio_complementario)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt11_estudio_complementario>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt11_estudio_complementario>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt12_archivo_complementario>()
                .Property(e => e.cod_archivo_complelemtario)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt12_archivo_complementario>()
                .Property(e => e.txt_path)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt12_archivo_complementario>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt12_archivo_complementario>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.hemograma)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.urinalisis)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.perfil_renal)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.perfil_lipidico)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.perfil_hepatico)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.perfil_triode)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.panel_metabolico)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.otros)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.txt_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt13_laboratorio>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt14_img_laboratorio>()
                .Property(e => e.cod_img_laboratorio)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt14_img_laboratorio>()
                .Property(e => e.txt_path)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt14_img_laboratorio>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt14_img_laboratorio>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt15_diagnostico>()
                .Property(e => e.cod_diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt15_diagnostico>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt15_diagnostico>()
                .Property(e => e.cod4_cie10)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt15_diagnostico>()
                .Property(e => e.txt_cie10)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt15_diagnostico>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt16_cie10>()
                .Property(e => e.cod_3)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt16_cie10>()
                .Property(e => e.txt_categoria)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt16_cie10>()
                .Property(e => e.cod_4)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt16_cie10>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt16_cie10>()
                .HasMany(e => e.CLIt15_diagnostico)
                .WithRequired(e => e.CLIt16_cie10)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIt17_tratamiento>()
                .Property(e => e.cod_tratamiento)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt17_tratamiento>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt17_tratamiento>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt18_evolucion>()
                .Property(e => e.cod_evolucion)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt18_evolucion>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt18_evolucion>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt19_cita>()
                .Property(e => e.cod_cita)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt19_cita>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt19_cita>()
                .Property(e => e.duracion)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt19_cita>()
                .Property(e => e.txt_obs)
                .IsUnicode(false);

            modelBuilder.Entity<CLIt19_cita>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<FISt01_control_numeracion>()
                .Property(e => e.txt_nro_serie)
                .IsUnicode(false);

            modelBuilder.Entity<FISt01_control_numeracion>()
                .Property(e => e.txt_serie_impresora)
                .IsUnicode(false);

            modelBuilder.Entity<FISt01_control_numeracion>()
                .Property(e => e.txt_info01)
                .IsUnicode(false);

            modelBuilder.Entity<FISt01_control_numeracion>()
                .Property(e => e.txt_info02)
                .IsUnicode(false);

            modelBuilder.Entity<FISt01_control_numeracion>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<FISt02_nivel>()
                .Property(e => e.cod_nivel)
                .IsUnicode(false);

            modelBuilder.Entity<FISt02_nivel>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<FISt02_nivel>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<FISt02_nivel>()
                .HasMany(e => e.FISt01_control_numeracion)
                .WithRequired(e => e.FISt02_nivel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FISt03_tipo_numeracion>()
                .Property(e => e.cod_tipo_numeracion)
                .IsUnicode(false);

            modelBuilder.Entity<FISt03_tipo_numeracion>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<FISt03_tipo_numeracion>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<FISt03_tipo_numeracion>()
                .HasMany(e => e.FISt01_control_numeracion)
                .WithRequired(e => e.FISt03_tipo_numeracion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRLt01_parametro>()
                .Property(e => e.cod_parametro)
                .IsUnicode(false);

            modelBuilder.Entity<GRLt01_parametro>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<GRLt01_parametro>()
                .Property(e => e.dec_valor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<GRLt01_parametro>()
                .Property(e => e.txt_valor)
                .IsUnicode(false);

            modelBuilder.Entity<GRLt01_parametro>()
                .Property(e => e.txt_obs)
                .IsUnicode(false);

            modelBuilder.Entity<GRLt02_estado>()
                .Property(e => e.cod_estado)
                .IsUnicode(false);

            modelBuilder.Entity<GRLt02_estado>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<GRLt02_estado>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<GRLt03_horario>()
                .Property(e => e.cod_horario)
                .IsUnicode(false);

            modelBuilder.Entity<GRLt03_horario>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<GRLt04_configuracion_caja>()
                .Property(e => e.txt_pathlog)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt01_medio_pago>()
                .Property(e => e.cod_medio_pago)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt01_medio_pago>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt01_medio_pago>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt02_descuento>()
                .Property(e => e.cod_descuento)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt02_descuento>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt02_descuento>()
                .Property(e => e.tipo_descuento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MSTt02_descuento>()
                .Property(e => e.porcentaje)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MSTt02_descuento>()
                .Property(e => e.monto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MSTt02_descuento>()
                .Property(e => e.monto_min)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MSTt02_descuento>()
                .Property(e => e.monto_max)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MSTt02_descuento>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt02_descuento>()
                .HasMany(e => e.TNSt08_descuento_dtl)
                .WithRequired(e => e.MSTt02_descuento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt03_tipo_orden>()
                .Property(e => e.cod_tipo_orden)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt03_tipo_orden>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt03_tipo_orden>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt03_tipo_orden>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt03_tipo_orden>()
                .HasMany(e => e.TNSt04_comp_emitido)
                .WithRequired(e => e.MSTt03_tipo_orden)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt04_canal_vta>()
                .Property(e => e.cod_can_vta)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt04_canal_vta>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt04_canal_vta>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt04_canal_vta>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt04_canal_vta>()
                .HasMany(e => e.TNSt04_comp_emitido)
                .WithRequired(e => e.MSTt04_canal_vta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt05_razon>()
                .Property(e => e.cod_razon)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt05_razon>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt05_razon>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt06_impuesto>()
                .Property(e => e.cod_impuesto)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt06_impuesto>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt06_impuesto>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt06_impuesto>()
                .Property(e => e.por_impto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<MSTt06_impuesto>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt06_impuesto>()
                .HasMany(e => e.TNSt01_comp_recibido)
                .WithRequired(e => e.MSTt06_impuesto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt07_estado_civil>()
                .Property(e => e.cod_estado_civil)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt07_estado_civil>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt07_estado_civil>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.cod_location)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_direccion1)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_direccion2)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_abrev1)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_abrev2)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.nro_ruc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.fono1)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.fono2)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_datos1)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_datos2)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_datos3)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_datos4)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt08_location>()
                .HasMany(e => e.TNSt04_comp_emitido)
                .WithRequired(e => e.MSTt08_location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt09_tipo_location>()
                .Property(e => e.cod_tipo_location)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt09_tipo_location>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt09_tipo_location>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt09_tipo_location>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt09_tipo_location>()
                .HasMany(e => e.MSTt08_location)
                .WithRequired(e => e.MSTt09_tipo_location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt10_impresora>()
                .Property(e => e.cod_impresora)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt10_impresora>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt10_impresora>()
                .Property(e => e.txt_ip)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt10_impresora>()
                .Property(e => e.txt_marca)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt10_impresora>()
                .Property(e => e.txt_modelo)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt10_impresora>()
                .Property(e => e.txt_info01)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt10_impresora>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt10_impresora>()
                .HasMany(e => e.MSTt12_caja)
                .WithOptional(e => e.MSTt10_impresora)
                .HasForeignKey(e => e.id_impresora);

            modelBuilder.Entity<MSTt10_impresora>()
                .HasMany(e => e.MSTt12_caja1)
                .WithOptional(e => e.MSTt10_impresora1)
                .HasForeignKey(e => e.id_impresora02);

            modelBuilder.Entity<MSTt10_impresora>()
                .HasMany(e => e.MSTt12_caja2)
                .WithOptional(e => e.MSTt10_impresora2)
                .HasForeignKey(e => e.id_impresora03);

            modelBuilder.Entity<MSTt10_impresora>()
                .HasMany(e => e.MSTt12_caja3)
                .WithOptional(e => e.MSTt10_impresora3)
                .HasForeignKey(e => e.id_impresora04);

            modelBuilder.Entity<MSTt10_impresora>()
                .HasMany(e => e.MSTt12_caja4)
                .WithOptional(e => e.MSTt10_impresora4)
                .HasForeignKey(e => e.id_impresora05);

            modelBuilder.Entity<MSTt10_impresora>()
                .HasMany(e => e.MSTt12_caja5)
                .WithOptional(e => e.MSTt10_impresora5)
                .HasForeignKey(e => e.id_impresora06);

            modelBuilder.Entity<MSTt11_tipo_impresora>()
                .Property(e => e.cod_tipo_impresora)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt11_tipo_impresora>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt11_tipo_impresora>()
                .Property(e => e.txt_info01)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt11_tipo_impresora>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt11_tipo_impresora>()
                .HasMany(e => e.MSTt10_impresora)
                .WithRequired(e => e.MSTt11_tipo_impresora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt12_caja>()
                .Property(e => e.cod_caja)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt12_caja>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt12_caja>()
                .Property(e => e.txt_ip)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt12_caja>()
                .Property(e => e.txt_info01)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt12_caja>()
                .Property(e => e.txt_info02)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt12_caja>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt12_caja>()
                .HasMany(e => e.CSHt01_caja_dtl)
                .WithRequired(e => e.MSTt12_caja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt12_caja>()
                .HasMany(e => e.GRLt04_configuracion_caja)
                .WithRequired(e => e.MSTt12_caja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt13_turno>()
                .Property(e => e.cod_turno)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt13_turno>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt13_turno>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt13_turno>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt13_turno>()
                .HasMany(e => e.CSHt01_caja_dtl)
                .WithRequired(e => e.MSTt13_turno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt13_turno>()
                .HasMany(e => e.TNSt04_comp_emitido)
                .WithRequired(e => e.MSTt13_turno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSTt14_mesa>()
                .Property(e => e.cod_mesa)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt14_mesa>()
                .Property(e => e.txt_num)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt15_estado_mesa>()
                .Property(e => e.cod_estado_mesa)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt15_estado_mesa>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt15_estado_mesa>()
                .Property(e => e.txt_color_hex)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt15_estado_mesa>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<MSTt15_estado_mesa>()
                .HasMany(e => e.MSTt14_mesa)
                .WithRequired(e => e.MSTt15_estado_mesa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERt01_usuario>()
                .Property(e => e.cod_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<PERt01_usuario>()
                .Property(e => e.txt_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<PERt01_usuario>()
                .Property(e => e.txt_clave)
                .IsUnicode(false);

            modelBuilder.Entity<PERt01_usuario>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.cod_cliente)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.cod_tipo_per)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.nro_doc)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.nro_ruc)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_ape_pat)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_ape_mat)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_pri_nom)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_seg_nom)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_rzn_social)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_nom_comercial)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.nom_via)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.nro_via)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.nom_zona)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_direccion1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_direccion2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_referencia)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_email1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_email2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_web)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.telef_fijo1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.telef_fijo2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.telef_fijo3)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.celular1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.celular2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.celular3)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.url_img)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info01)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info02)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info03)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info04)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info05)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info06)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info07)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info08)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info09)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.info10)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PERt02_cliente>()
                .HasMany(e => e.TNSt04_comp_emitido)
                .WithRequired(e => e.PERt02_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.cod_proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.cod_tipo_per)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.nro_doc)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.nro_ruc)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_ape_pat)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_ape_mat)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_pri_nom)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_seg_nom)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_rzn_social)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_nom_comercial)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.nom_via)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.nro_via)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.nom_zona)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_direccion1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_direccion2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_referencia)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_email1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_email2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_web)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.telef_fijo1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.telef_fijo2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.telef_fijo3)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.celular1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.celular2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.celular3)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.url_img)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info01)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info02)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info03)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info04)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info05)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info06)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info07)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info08)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info09)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.info10)
                .IsUnicode(false);

            modelBuilder.Entity<PERt03_proveedor>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.cod_empleado)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.cod_tipo_per)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.nro_doc)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.nro_ruc)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_ape_pat)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_ape_mat)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_pri_nom)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_seg_nom)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_rzn_social)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_nom_comercial)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.nom_via)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.nro_via)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.nom_zona)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_direccion1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_direccion2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_referencia)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_email1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_email2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_web)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.telef_fijo1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.telef_fijo2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.telef_fijo3)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.celular1)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.celular2)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.celular3)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.url_img)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info01)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info02)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info03)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info04)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info05)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info06)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info07)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info08)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info09)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.info10)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.salario_mensual)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.salario_quincenal)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.salario_hora)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.nro_hora_mes)
                .HasPrecision(8, 4);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.nro_cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PERt04_empleado>()
                .HasMany(e => e.CLIt03_atencion)
                .WithRequired(e => e.PERt04_empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERt04_empleado>()
                .HasMany(e => e.CLIt04_atencion_dtl)
                .WithRequired(e => e.PERt04_empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERt04_empleado>()
                .HasMany(e => e.CLIt19_cita)
                .WithRequired(e => e.PERt04_empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERt04_empleado>()
                .HasMany(e => e.CSHt01_caja_dtl)
                .WithRequired(e => e.PERt04_empleado)
                .HasForeignKey(e => e.id_empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERt04_empleado>()
                .HasMany(e => e.CSHt01_caja_dtl1)
                .WithRequired(e => e.PERt04_empleado1)
                .HasForeignKey(e => e.id_emp_autorizador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERt04_empleado>()
                .HasMany(e => e.PERt01_usuario)
                .WithRequired(e => e.PERt04_empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERt04_empleado>()
                .HasMany(e => e.TNSt04_comp_emitido)
                .WithOptional(e => e.PERt04_empleado)
                .HasForeignKey(e => e.id_empleado);

            modelBuilder.Entity<PERt04_empleado>()
                .HasMany(e => e.TNSt04_comp_emitido1)
                .WithOptional(e => e.PERt04_empleado1)
                .HasForeignKey(e => e.id_emp_autorizador);

            modelBuilder.Entity<PERt05_categoria_emp>()
                .Property(e => e.cod_categoria_emp)
                .IsUnicode(false);

            modelBuilder.Entity<PERt05_categoria_emp>()
                .Property(e => e.txt_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<PERt05_categoria_emp>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PERt05_categoria_emp>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PERt06_clase_emp>()
                .Property(e => e.cod_clase_emp)
                .IsUnicode(false);

            modelBuilder.Entity<PERt06_clase_emp>()
                .Property(e => e.txt_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<PERt06_clase_emp>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PERt06_clase_emp>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt01_marca>()
                .Property(e => e.cod_marca)
                .IsUnicode(false);

            modelBuilder.Entity<PROt01_marca>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt01_marca>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt01_marca>()
                .HasMany(e => e.PROt02_modelo)
                .WithRequired(e => e.PROt01_marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROt02_modelo>()
                .Property(e => e.cod_modelo)
                .IsUnicode(false);

            modelBuilder.Entity<PROt02_modelo>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt02_modelo>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt03_familia>()
                .Property(e => e.cod_familia)
                .IsUnicode(false);

            modelBuilder.Entity<PROt03_familia>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt03_familia>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt03_familia>()
                .HasMany(e => e.PROt04_subfamilia)
                .WithRequired(e => e.PROt03_familia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROt04_subfamilia>()
                .Property(e => e.cod_subfamilia)
                .IsUnicode(false);

            modelBuilder.Entity<PROt04_subfamilia>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt04_subfamilia>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt05_grupo_prod>()
                .Property(e => e.cod_grupo_prod)
                .IsUnicode(false);

            modelBuilder.Entity<PROt05_grupo_prod>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt05_grupo_prod>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt05_grupo_prod>()
                .HasMany(e => e.PROt06_clase_prod)
                .WithRequired(e => e.PROt05_grupo_prod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROt06_clase_prod>()
                .Property(e => e.cod_clase_prod)
                .IsUnicode(false);

            modelBuilder.Entity<PROt06_clase_prod>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt06_clase_prod>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt07_tipo_prod>()
                .Property(e => e.cod_tipo_prod)
                .IsUnicode(false);

            modelBuilder.Entity<PROt07_tipo_prod>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt07_tipo_prod>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_1)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_2)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_3)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_4)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_5)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_6)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_7)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_8)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_9)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_sin_igv_10)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_1)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_2)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_3)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_4)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_5)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_6)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_7)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_8)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_9)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_pu_con_igv_10)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_1)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_2)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_3)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_4)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_5)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_6)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_7)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_8)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_9)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.mto_costo_10)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.txt_obsv)
                .IsUnicode(false);

            modelBuilder.Entity<PROt08_precio_prod>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.cod_producto)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.cod_producto2)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.cod_barra)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.por_impto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.mto_pvpu_con_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.mto_pvmi_con_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.mto_pvma_con_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.mto_pvpu_sin_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.mto_pvmi_sin_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.mto_pvma_sin_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.costo_prod)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.peso_prod)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.largo_prod)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.ancho_prod)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.altura_prod)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.diametro_prod)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.url_img_prod)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.txt_referencia)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt09_producto>()
                .HasMany(e => e.TNSt02_comp_recibido_dtl)
                .WithRequired(e => e.PROt09_producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROt09_producto>()
                .HasMany(e => e.PROt16_combo_variable_dtl)
                .WithRequired(e => e.PROt09_producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROt10_receta>()
                .Property(e => e.cod_receta)
                .IsUnicode(false);

            modelBuilder.Entity<PROt10_receta>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt10_receta>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt10_receta>()
                .HasMany(e => e.PROt11_receta_dtl)
                .WithRequired(e => e.PROt10_receta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROt11_receta_dtl>()
                .Property(e => e.txt_producto)
                .IsUnicode(false);

            modelBuilder.Entity<PROt11_receta_dtl>()
                .Property(e => e.peso)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt11_receta_dtl>()
                .Property(e => e.cantidad)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt12_receta_grupo>()
                .Property(e => e.cod_receta_grupo)
                .IsUnicode(false);

            modelBuilder.Entity<PROt12_receta_grupo>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt12_receta_grupo>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt13_combo>()
                .Property(e => e.cod_combo)
                .IsUnicode(false);

            modelBuilder.Entity<PROt13_combo>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt13_combo>()
                .Property(e => e.mto_pvpu_sin_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt13_combo>()
                .Property(e => e.mto_pvpu_con_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt13_combo>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt13_combo>()
                .HasMany(e => e.PROt14_combo_fixed_dtl)
                .WithRequired(e => e.PROt13_combo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROt14_combo_fixed_dtl>()
                .Property(e => e.cod_combo_fixed_dtl)
                .IsUnicode(false);

            modelBuilder.Entity<PROt14_combo_fixed_dtl>()
                .Property(e => e.cantidad)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt14_combo_fixed_dtl>()
                .Property(e => e.mto_pvpu_sin_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt14_combo_fixed_dtl>()
                .Property(e => e.mto_pvpu_con_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt14_combo_fixed_dtl>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt15_combo_variable>()
                .Property(e => e.cod_combo_variable)
                .IsUnicode(false);

            modelBuilder.Entity<PROt15_combo_variable>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt15_combo_variable>()
                .Property(e => e.mto_pvpu_sin_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt15_combo_variable>()
                .Property(e => e.mto_pvpu_con_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt15_combo_variable>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt15_combo_variable>()
                .HasMany(e => e.PROt16_combo_variable_dtl)
                .WithRequired(e => e.PROt15_combo_variable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROt16_combo_variable_dtl>()
                .Property(e => e.cod_combo_variable_dtl)
                .IsUnicode(false);

            modelBuilder.Entity<PROt16_combo_variable_dtl>()
                .Property(e => e.cantidad)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt16_combo_variable_dtl>()
                .Property(e => e.mto_pvpu_sin_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt16_combo_variable_dtl>()
                .Property(e => e.mto_pvpu_con_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<PROt16_combo_variable_dtl>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt17_combo_grupo>()
                .Property(e => e.cod_combo_grupo)
                .IsUnicode(false);

            modelBuilder.Entity<PROt17_combo_grupo>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<PROt17_combo_grupo>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<PROt17_combo_grupo>()
                .HasMany(e => e.PROt13_combo)
                .WithRequired(e => e.PROt17_combo_grupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RPTt01_reporte>()
                .Property(e => e.cod_reporte)
                .IsUnicode(false);

            modelBuilder.Entity<RPTt01_reporte>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<RPTt01_reporte>()
                .Property(e => e.txt_path)
                .IsUnicode(false);

            modelBuilder.Entity<RPTt01_reporte>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<RPTt02_categoria_reporte>()
                .Property(e => e.cod_categoria_reporte)
                .IsUnicode(false);

            modelBuilder.Entity<RPTt02_categoria_reporte>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<RPTt02_categoria_reporte>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<RPTt02_categoria_reporte>()
                .HasMany(e => e.RPTt01_reporte)
                .WithRequired(e => e.RPTt02_categoria_reporte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt01_tipo_medio_pago>()
                .Property(e => e.cod_tipo_medio_pago)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt01_tipo_medio_pago>()
                .Property(e => e.cod_tipo_medio_pago_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt01_tipo_medio_pago>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt01_tipo_medio_pago>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt02_tipo_doc_identidad>()
                .Property(e => e.cod_tipo_doc_identidad)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt02_tipo_doc_identidad>()
                .Property(e => e.cod_tipo_doc_identidad_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt02_tipo_doc_identidad>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt02_tipo_doc_identidad>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt02_tipo_doc_identidad>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt03_entidad_financiera>()
                .Property(e => e.cod_entidad_financiera)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt03_entidad_financiera>()
                .Property(e => e.cod_entidad_financiera_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt03_entidad_financiera>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt03_entidad_financiera>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt04_tipo_moneda>()
                .Property(e => e.cod_tipo_moneda)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt04_tipo_moneda>()
                .Property(e => e.cod_tipo_moneda_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt04_tipo_moneda>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt04_tipo_moneda>()
                .Property(e => e.dec_cambio)
                .HasPrecision(18, 8);

            modelBuilder.Entity<SNTt04_tipo_moneda>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt04_tipo_moneda>()
                .Property(e => e.txt_pais)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt04_tipo_moneda>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt04_tipo_moneda>()
                .HasMany(e => e.TNSt01_comp_recibido)
                .WithRequired(e => e.SNTt04_tipo_moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt04_tipo_moneda>()
                .HasMany(e => e.TNSt04_comp_emitido)
                .WithRequired(e => e.SNTt04_tipo_moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt05_tipo_existencia>()
                .Property(e => e.cod_tipo_existencia)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt05_tipo_existencia>()
                .Property(e => e.cod_tipo_existencia_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt05_tipo_existencia>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt05_tipo_existencia>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .Property(e => e.cod_um)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .Property(e => e.cod_um_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .Property(e => e.txt_unid_base)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .Property(e => e.txt_operacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .Property(e => e.dec_factor)
                .HasPrecision(18, 8);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .HasMany(e => e.PROt11_receta_dtl)
                .WithRequired(e => e.SNTt06_unidad_medida)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .HasMany(e => e.TNSt02_comp_recibido_dtl)
                .WithRequired(e => e.SNTt06_unidad_medida)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt06_unidad_medida>()
                .HasMany(e => e.TNSt05_comp_emitido_dtl)
                .WithRequired(e => e.SNTt06_unidad_medida)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt07_tipo_intangible>()
                .Property(e => e.cod_tipo_intangible)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt07_tipo_intangible>()
                .Property(e => e.cod_tipo_intangible_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt07_tipo_intangible>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt07_tipo_intangible>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt08_codigo_libro>()
                .Property(e => e.cod_libro)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt08_codigo_libro>()
                .Property(e => e.cod_libro_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt08_codigo_libro>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt08_codigo_libro>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt09_cta_contable>()
                .Property(e => e.cod_cta_contable)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt09_cta_contable>()
                .Property(e => e.cod_cta_contable_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt09_cta_contable>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt09_cta_contable>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt09_cta_contable>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .Property(e => e.cod_tipo_comp)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .Property(e => e.cod_tipo_comp_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .Property(e => e.cod_location)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .Property(e => e.nro_caja)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .Property(e => e.nro_serie)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .HasMany(e => e.FISt01_control_numeracion)
                .WithRequired(e => e.SNTt10_tipo_comprobante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .HasMany(e => e.TNSt01_comp_recibido)
                .WithRequired(e => e.SNTt10_tipo_comprobante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt10_tipo_comprobante>()
                .HasMany(e => e.TNSt04_comp_emitido)
                .WithRequired(e => e.SNTt10_tipo_comprobante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt11_aduana>()
                .Property(e => e.cod_aduana)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt11_aduana>()
                .Property(e => e.cod_aduana_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt11_aduana>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt11_aduana>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt12_tipo_operacion>()
                .Property(e => e.cod_tipo_operacion)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt12_tipo_operacion>()
                .Property(e => e.cod_tipo_operacion_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt12_tipo_operacion>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt12_tipo_operacion>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt13_tipo_actividad>()
                .Property(e => e.cod_tipo_actividad)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt13_tipo_actividad>()
                .Property(e => e.cod_tipo_actividad_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt13_tipo_actividad>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt13_tipo_actividad>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt13_tipo_actividad>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt14_nacionalidad>()
                .Property(e => e.cod_nacionalidad)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt14_nacionalidad>()
                .Property(e => e.cod_nacionalidad_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt14_nacionalidad>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt14_nacionalidad>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt14_nacionalidad>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt15_via>()
                .Property(e => e.cod_via)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt15_via>()
                .Property(e => e.cod_via_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt15_via>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt15_via>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt15_via>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt16_zona>()
                .Property(e => e.cod_zona)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt16_zona>()
                .Property(e => e.cod_zona_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt16_zona>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt16_zona>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt16_zona>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt17_tipo_trabajador>()
                .Property(e => e.cod_tipo_trabajador)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt17_tipo_trabajador>()
                .Property(e => e.cod_tipo_trabajador_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt17_tipo_trabajador>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt17_tipo_trabajador>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt17_tipo_trabajador>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt18_situacion_educativa>()
                .Property(e => e.cod_situacion_educativa)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt18_situacion_educativa>()
                .Property(e => e.cod_situacion_educativa_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt18_situacion_educativa>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt18_situacion_educativa>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt18_situacion_educativa>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt19_ocupacion>()
                .Property(e => e.cod_ocupacion)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt19_ocupacion>()
                .Property(e => e.cod_ocupacion_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt19_ocupacion>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt19_ocupacion>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt19_ocupacion>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt20_regimen_pensionario>()
                .Property(e => e.cod_regimen_pensionario)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt20_regimen_pensionario>()
                .Property(e => e.cod_regimen_pensionario_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt20_regimen_pensionario>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt20_regimen_pensionario>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt20_regimen_pensionario>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt21_condicion_laboral>()
                .Property(e => e.cod_condicion_laboral)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt21_condicion_laboral>()
                .Property(e => e.cod_condicion_laboral_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt21_condicion_laboral>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt21_condicion_laboral>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt21_condicion_laboral>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt22_periodo_remuneracion>()
                .Property(e => e.cod_periodo_remuneracion)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt22_periodo_remuneracion>()
                .Property(e => e.cod_periodo_remuneracion_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt22_periodo_remuneracion>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt22_periodo_remuneracion>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt22_periodo_remuneracion>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt23_salud_eps>()
                .Property(e => e.cod_salud_eps)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt23_salud_eps>()
                .Property(e => e.cod_salud_eps_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt23_salud_eps>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt23_salud_eps>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt23_salud_eps>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt24_situacion>()
                .Property(e => e.cod_situacion)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt24_situacion>()
                .Property(e => e.cod_situacion_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt24_situacion>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt24_situacion>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt24_situacion>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt25_motivo_baja>()
                .Property(e => e.cod_motivo_baja)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt25_motivo_baja>()
                .Property(e => e.cod_motivo_baja_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt25_motivo_baja>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt25_motivo_baja>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt25_motivo_baja>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt26_modalidad_formativa>()
                .Property(e => e.cod_modalidad_formativa)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt26_modalidad_formativa>()
                .Property(e => e.cod_modalidad_formativa_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt26_modalidad_formativa>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt26_modalidad_formativa>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt26_modalidad_formativa>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt27_vinculo_familiar>()
                .Property(e => e.cod_vinculo_familiar)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt27_vinculo_familiar>()
                .Property(e => e.cod_vinculo_familiar_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt27_vinculo_familiar>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt27_vinculo_familiar>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt27_vinculo_familiar>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt28_suspencion_laboral>()
                .Property(e => e.cod_suspencion_laboral)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt28_suspencion_laboral>()
                .Property(e => e.cod_suspencion_laboral_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt28_suspencion_laboral>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt28_suspencion_laboral>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt28_suspencion_laboral>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt29_regimen_salud>()
                .Property(e => e.cod_regimen_salud)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt29_regimen_salud>()
                .Property(e => e.cod_regimen_salud_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt29_regimen_salud>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt29_regimen_salud>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt29_regimen_salud>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt30_regimen_laboral>()
                .Property(e => e.cod_regimen_laboral)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt30_regimen_laboral>()
                .Property(e => e.cod_regimen_laboral_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt30_regimen_laboral>()
                .Property(e => e.txt_abrv)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt30_regimen_laboral>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt30_regimen_laboral>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt31_departamento>()
                .Property(e => e.cod_dpto)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt31_departamento>()
                .Property(e => e.cod_dpto_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt31_departamento>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt31_departamento>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt31_departamento>()
                .HasMany(e => e.SNTt32_provincia)
                .WithRequired(e => e.SNTt31_departamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt32_provincia>()
                .Property(e => e.cod_prov)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt32_provincia>()
                .Property(e => e.cod_prov_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt32_provincia>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt32_provincia>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt32_provincia>()
                .HasMany(e => e.SNTt33_distrito)
                .WithRequired(e => e.SNTt32_provincia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SNTt33_distrito>()
                .Property(e => e.cod_dist)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt33_distrito>()
                .Property(e => e.cod_dist_ple)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt33_distrito>()
                .Property(e => e.txt_desc)
                .IsUnicode(false);

            modelBuilder.Entity<SNTt33_distrito>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.nro_comp_recibido)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.txt_serie)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.txt_numero)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.por_impto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.txt_observ)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_tc_vta)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_neto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_exonerado)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_no_afecto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_dscto_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_cms_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_flete_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_sub_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_impto_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_servicio)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.mto_tot_comp)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.ref_tipo_comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.ref_serie)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.ref_numero)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.txt_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .HasMany(e => e.TNSt02_comp_recibido_dtl)
                .WithOptional(e => e.TNSt01_comp_recibido)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TNSt01_comp_recibido>()
                .HasMany(e => e.TNSt03_comp_recibido_estado)
                .WithOptional(e => e.TNSt01_comp_recibido)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TNSt02_comp_recibido_dtl>()
                .Property(e => e.txt_producto)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt02_comp_recibido_dtl>()
                .Property(e => e.qt_comp)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt02_comp_recibido_dtl>()
                .Property(e => e.punit_sin_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt02_comp_recibido_dtl>()
                .Property(e => e.punit_con_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt02_comp_recibido_dtl>()
                .Property(e => e.por_dscto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt02_comp_recibido_dtl>()
                .Property(e => e.punit_dscto_sin_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt02_comp_recibido_dtl>()
                .Property(e => e.punit_dscto_con_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt02_comp_recibido_dtl>()
                .Property(e => e.mto_comp_sin_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt02_comp_recibido_dtl>()
                .Property(e => e.mto_comp_con_igv)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt03_comp_recibido_estado>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt03_comp_recibido_estado>()
                .Property(e => e.txt_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.nro_comp_emitido)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.cod_caja)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.txt_serie)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.txt_numero)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.txt_serie_fe)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.txt_numero_fe)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.txt_observ)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.mto_tc_vta)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.mto_neto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.mto_exonerado)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.mto_no_afecto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.mto_dscto_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.mto_servicio)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.mto_sub_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.mto_impto_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.mto_tot_comp)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.ref_tipo_comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.ref_serie)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.ref_numero)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_por01)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_por02)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_por03)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_por04)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_por05)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_por06)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_por07)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_por08)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_mto01)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_mto02)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_mto03)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_mto04)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_mto05)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_mto06)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_mto07)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.tax_mto08)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info01)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info02)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info03)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info04)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info05)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info06)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info07)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info08)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info09)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info10)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info_mto01)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info_mto02)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info_mto03)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info_mto04)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.info_mto05)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.txt_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt04_comp_emitido>()
                .HasMany(e => e.TNSt05_comp_emitido_dtl)
                .WithOptional(e => e.TNSt04_comp_emitido)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.txt_producto)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.cantidad)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.peso)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.por_dscto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.mto_dscto_sin_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.mto_dscto_con_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.punit_sin_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.punit_con_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_por_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_mto_tot)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_por01)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_por02)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_por03)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_por04)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_por05)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_por06)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_por07)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_por08)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_mto01)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_mto02)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_mto03)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_mto04)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_mto05)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_mto06)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_mto07)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.tax_mto08)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.mto_vta_sin_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.mto_vta_con_tax)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.txt_observ)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt05_comp_emitido_dtl>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt06_comp_emitido_estado>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt06_comp_emitido_estado>()
                .Property(e => e.txt_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt07_medio_pago_dtl>()
                .Property(e => e.impuesto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt07_medio_pago_dtl>()
                .Property(e => e.monto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt07_medio_pago_dtl>()
                .Property(e => e.mto_tipo_cambio)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt07_medio_pago_dtl>()
                .Property(e => e.txt_observ)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt07_medio_pago_dtl>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt08_descuento_dtl>()
                .Property(e => e.porcentaje)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt08_descuento_dtl>()
                .Property(e => e.monto)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TNSt08_descuento_dtl>()
                .Property(e => e.txt_observ)
                .IsUnicode(false);

            modelBuilder.Entity<TNSt08_descuento_dtl>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_ordenes)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_boletas)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_facturas)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_not_cred)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_comprobantes)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago01)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago02)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago03)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago04)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago05)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago06)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago07)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago08)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago09)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.mto_forma_pago10)
                .HasPrecision(18, 8);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.txt_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TOTt01_total_diario_vta>()
                .Property(e => e.txt_estado)
                .IsUnicode(false);
        }
    }
}
