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
                new Instructor(){Id=1,LegajoVuelo=1346, Nombre="Cristina",Apellido="Alonso",DNI=134,Tra=1,EnActividad=true ,Hangar=1},
                new Instructor(){Id=2,LegajoVuelo=1346, Nombre="Antonio", Apellido="Lopez",DNI=134,Tra=1,EnActividad=true ,Hangar=1},
                new Instructor(){Id=3,LegajoVuelo=1346, Nombre="Graciela",Apellido="Martinez",DNI=134,Tra=1,EnActividad=true ,Hangar=1},
                new Instructor(){Id=4,LegajoVuelo=1346, Nombre="Oscar",Apellido="Rossi",DNI=134,Tra=1,EnActividad=true ,Hangar=1},
                new Instructor(){Id=5,LegajoVuelo=1346, Nombre="Cynthia",Apellido="Ferrari",DNI=134,Tra=1,EnActividad=true ,Hangar=1},
                new Instructor(){Id=6,LegajoVuelo=1346, Nombre="Nadine",Apellido="Sharpe",DNI=134,Tra=1,EnActividad=true ,Hangar=1},
                new Instructor(){Id=7,LegajoVuelo=1346, Nombre="Walter",Apellido="Rodgers",DNI=134,Tra=1,EnActividad=true ,Hangar=1},
                new Instructor(){Id=8,LegajoVuelo=1346, Nombre="Nadine",Apellido="Melton",DNI=134,Tra=1,EnActividad=true ,Hangar=1},
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