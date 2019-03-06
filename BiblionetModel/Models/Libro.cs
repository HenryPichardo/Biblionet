using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblionetModel.Models
{
    public class Libro
    {
        public int LibroID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Edicion { get; set; }
        public string Editora { get; set; }
        public int Año { get; set; }
        public virtual ICollection<Registro> Registros { get; set; }
    }

}
