using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblionetModel.Models
{
    public class Registro
    {
        public int RegistroID { get; set; }
        public int AsignaturaID { get; set; }
        public int LibroID { get; set; }

        public virtual Asignatura Asignatura { get; set; }
        public virtual Libro Libro { get; set; }

    }
}
