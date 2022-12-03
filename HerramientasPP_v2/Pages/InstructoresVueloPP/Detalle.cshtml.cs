using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrimerParcial.Models;
using PrimerParcial.Servicios;

namespace ProyHerramientas.Pages.Profesores //ACA ESTA UN PROFESORES
{
    public class DetalleModel : PageModel
    {
        [BindProperty]
        public Instructor InstructorDetalle{get;set;}
        private IInstructorServicio _instSrv;
        public DetalleModel(IInstructorServicio instSrv){
            _instSrv=instSrv;
        }

        public void OnGet(int id)
        {
            InstructorDetalle=_instSrv.MostrarTodos()
                    .Where(x=>x.Id==id)
                    .First();
        }
    }
}