using PrimerParcial.Models;

namespace PrimerParcial.Servicios
{
    public interface IInstructorServicio{
        List<Instructor> MostrarTodos();
        void Agregar(Instructor instructornuevo);
        void Modificar(Instructor instructoreditado);
        void Eliminar(Instructor instructorborrado);
    }
    public class InstructorServicio : IInstructorServicio
    {
        private List<Instructor> ListaCompletaInstructores;
        public InstructorServicio(){
           ListaCompletaInstructores=new List<Instructor>()
            {
                new Instructor(){Id=1,Nombre="Cristina",Apellido="Alonso",EnActividad=true ,Experiencia=3},
                new Instructor(){Id=2,Nombre="Antonio",Apellido="Lopez",EnActividad=true ,Experiencia=1},
                new Instructor(){Id=3,Nombre="Graciela",Apellido="Martinez",EnActividad=true ,Experiencia=2},
                new Instructor(){Id=4,Nombre="Oscar",Apellido="Rossi",EnActividad=true ,Experiencia=4},
                new Instructor(){Id=5,Nombre="Cynthia",Apellido="Ferrari",EnActividad=true ,Experiencia=3},
                new Instructor(){Id=6,Nombre="Nadine",Apellido="Sharpe",EnActividad=true ,Experiencia=3},
                new Instructor(){Id=7,Nombre="Walter",Apellido="Rodgers",EnActividad=true ,Experiencia=3},
                new Instructor(){Id=8,Nombre="Nadine",Apellido="Melton",EnActividad=true ,Experiencia=3},
                //new Instructor(){Id=9,Nombre="Maite",Apellido="Rodgers"},
            };
        }
        public List<Instructor> MostrarTodos(){
            return ListaCompletaInstructores;
        }
        public void  Agregar(Instructor Instructornuevo){
            ListaCompletaInstructores.Add(Instructornuevo);
        }
        public void Modificar(Instructor instructoreditado){
            var instructorSinModificar=ListaCompletaInstructores.Where(x=>x.Id==instructoreditado.Id).First();
            ListaCompletaInstructores.Remove(instructorSinModificar);
            ListaCompletaInstructores.Add(instructoreditado);
        }
        public void Eliminar(Instructor instructorborrado){
            var instructorborrar=ListaCompletaInstructores.Where(x=>x.Id==instructorborrado.Id).First();
            ListaCompletaInstructores.Remove(instructorborrar);
        }
    }
}