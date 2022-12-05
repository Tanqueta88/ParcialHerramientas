using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrimerParcial.Models;
using PrimerParcial.Servicios;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PrimerParcial.Pages
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Instructor InstructorIng {get;set;}
        public List<SelectListItem> HangaresLista {get;set;}
         private IInstructorServicio _instrv;
         private IHangarServicio _hanSrv;
         
        public CrearModel(IInstructorServicio srv, IHangarServicio hanSrv){
            _instrv=srv;
            _hanSrv=hanSrv;
        }
        public void OnGet(int id)
        {
            var lista= _instrv.MostrarTodos();
            // InstructorIng=lista.Where(x=>x.Id==id).First();
            HangaresLista=_hanSrv.MostrarHangares().Select(a=>
                               new SelectListItem{
                                    Value=a.Id.ToString(),
                                    Text=a.Detalle
                                }
                            ).ToList();
        }

        public IActionResult OnPost(){
            if(ModelState.IsValid){
                _instrv.Agregar(InstructorIng);
                return RedirectToPage("Listado");
            }
           else{
            return Page();
           }
        }   
        
    }
}
