using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrimerParcial.Models;
using PrimerParcial.Servicios;

namespace PrimerParcial.Pages.InstructoresVueloPP
{
    public class ListadoModel : PageModel
    {
        [BindProperty]
        public List<Instructor> NominaInstructores {get;set;}

        private IInstructorServicio _instructorServicio;
        public string NombreOrden;
        public ListadoModel(IInstructorServicio instSrv){
            _instructorServicio=instSrv;
        }
        public void OnGet(string FiltroNombre,string FiltroApellido,string CampoOrden)
        {
           NominaInstructores=_instructorServicio.MostrarTodos();
           NombreOrden = (CampoOrden == "Nombre_Asc") ? "Nombre_Desc" : "Nombre_Asc";
                            
           if(FiltroNombre!=null && FiltroNombre.Length > 0)
            {
                NominaInstructores = NominaInstructores
                                    .Where(x => 
                                            x.Nombre.ToUpper()
                                            .Contains(FiltroNombre.ToUpper())   
                                           )
                                    .ToList();
            }
            switch (CampoOrden) {
                case "Nombre_Asc":
                    NominaInstructores = NominaInstructores.OrderBy(x => x.Nombre).ToList();
                    break;
                case "Nombre_Desc":
                    NominaInstructores = NominaInstructores.OrderByDescending(x => x.Nombre).ToList();
                    break;
                case "OrdenPorApellido":
                    NominaInstructores = NominaInstructores.OrderBy(x => x.Apellido).ToList();
                    break;
                case "OrdenPorApellidoDesc":
                    NominaInstructores = NominaInstructores.OrderByDescending(x => x.Apellido).ToList();
                    break;
                default:
                    NominaInstructores = NominaInstructores.OrderBy(x => x.Id).ToList();
                    break;
            }
            
        }
        public void OnGetBorrar(int idBorrar) {
            var profeborrar = _instructorServicio.MostrarTodos().Where(x => x.Id == idBorrar).First();
            _instructorServicio.Eliminar(profeborrar);
            NominaInstructores =_instructorServicio.MostrarTodos().ToList();
        }
    }
}