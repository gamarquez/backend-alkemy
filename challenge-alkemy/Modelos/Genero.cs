using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_alkemy.Modelos
{
    public class Genero
    {
        [Key]
        public int Id_Genero { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }

        public ICollection<PeliculaSerie> PeliculaSeries { get; set; }

    }
}
