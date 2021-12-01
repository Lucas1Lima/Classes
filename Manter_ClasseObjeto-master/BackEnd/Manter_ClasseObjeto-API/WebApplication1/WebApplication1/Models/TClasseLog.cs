using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TClasseLog
    {

        [Key]
        public int Id { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required, StringLength(50)]
        public string UsuarioResponsavel { get; set; }

        [Required, StringLength(200)]
        public string Modificacoes { get; set; }
    }
}
