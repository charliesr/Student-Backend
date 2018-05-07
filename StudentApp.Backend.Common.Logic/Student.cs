using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApp.Backend.Common.Logic
{
    public class Student
    {
        #region Propiedades
        public Guid Guid { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public int Edad { get; set; }
        #endregion
    }
}
