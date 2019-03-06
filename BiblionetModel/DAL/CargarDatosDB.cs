using BiblionetModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblionetModel.DAL
{
    public class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibroContext>
    {
        protected override void Seed(LibroContext context)
        {
            var Asignaturas = new List<Asignatura>
            {
                new Asignatura{AsignaturaID=1,ASIGNATURA="Matematica",},
                new Asignatura{AsignaturaID=2,ASIGNATURA="Ciencias Naturales",},
                new Asignatura{AsignaturaID=3,ASIGNATURA="Historia",},
                new Asignatura{AsignaturaID=4,ASIGNATURA="Lengua Española",}
            };
            Asignaturas.ForEach(s => context.Asignaturas.Add(s));
            context.SaveChanges();

            var Libros = new List<Libro>
            {
                new Libro{Titulo="Matematica Basica",Autor="Henry Pichardo",Edicion="Octava Edicion",Editora="Mcgraw Hill",Año=1999,},
                new Libro{Titulo="Ciencias Naturales 7mo",Autor="Yordy De La Cruz",Edicion="Primera Edicion",Editora="Disesa",Año=2001,},
                new Libro{Titulo="Historia Dominicana",Autor="Ronald Peña",Edicion="Segunda Edicion",Editora="Susaeta",Año=1999,},
                new Libro{Titulo="Lengua Española 8vo",Autor="Yerinson Perez",Edicion="Tercera Edicion",Editora="Editora Corripio",Año=1999,}
            };
            Libros.ForEach(s => context.Libros.Add(s));
            context.SaveChanges();

            var Registros = new List<Registro>
            {
                new Registro{LibroID=1,AsignaturaID=1,},
                new Registro{LibroID=2,AsignaturaID=2,},
                new Registro{LibroID=3,AsignaturaID=3,},
                new Registro{LibroID=4,AsignaturaID=4,},
            };
            Registros.ForEach(s => context.Registros.Add(s));
            context.SaveChanges();

        }
    }
}
