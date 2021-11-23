using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_alkemy.Modelos
{
    public class PeliculaSerie
    {
        [Key]
        public int Id_PeliculaSerie { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha_De_Creacion { get; set; }
        public int Calificacion { get; set; }

        public ICollection<Personaje> Personajes { get; set; }

    }
}
