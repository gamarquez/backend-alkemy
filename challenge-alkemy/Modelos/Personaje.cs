using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_alkemy.Modelos
{
    public class Personaje
    {
        [Key]
        public int Id_Personaje { get; set; }
        public string Imagen { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }
        public string Historia { get; set; }

        public ICollection<PeliculaSerie> PeliculaSeries { get; set; }

    }
}
