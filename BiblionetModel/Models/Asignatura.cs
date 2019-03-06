using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblionetModel.Models
{
    public class Asignatura
    {
        public int AsignaturaID { get; set; }
        public string ASIGNATURA { get; set; }

        public virtual ICollection<Registro> Registros { get; set; }
    }
}
