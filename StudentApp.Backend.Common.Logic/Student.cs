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

        public Student()
        {

        }
        public Student(Guid guid, int Id, string dni, string nombre, string apellidos, int edad, DateTime nacimiento, DateTime registro)
        {
            this.Guid = guid;
            this.ID = Id;
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.FechaDeNacimiento = nacimiento;
            this.FechaHoraRegistro = registro;
        }
        public Student(Guid guid, string dni, string nombre, string apellidos, int edad, DateTime nacimiento, DateTime registro)
        {
            this.Guid = guid;
            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.FechaDeNacimiento = nacimiento;
            this.FechaHoraRegistro = registro;
        }
    }
}
