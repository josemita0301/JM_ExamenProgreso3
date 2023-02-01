using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxLengthAttribute = SQLite.MaxLengthAttribute;

namespace JM_ExamenProgreso3.JM_Models
{
    [Table("Perro")]
    public class JM_Perro
    {
        [PrimaryKey, AutoIncrement]
        public int JM_id { get; set; }

        [MaxLength(10)]
        public string JM_descripcionEnfermedad{ get; set; }
        public string JM_raza { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime JM_CreationDate { get; set; }
    }
}
