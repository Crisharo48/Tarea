using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Tarea.Models
{
    public class Operacion
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoOperacion { get; set; }
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Resultado { get; set; }
    }
}
