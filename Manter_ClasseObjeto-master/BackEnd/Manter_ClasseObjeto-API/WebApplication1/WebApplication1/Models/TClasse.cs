using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TClasse
    {
        public int Id { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Required, StringLength(50)]
        public string Descricao { get; set; }
    }
}
