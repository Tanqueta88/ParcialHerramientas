using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrimerParcial.Models;
using PrimerParcial.Servicios;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace PrimerParcial.Pages.InstructoresVueloPP
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Instructor InstructorEdit {get;set;}
        public List<SelectListItem> HangaresLista {get;set;}

        private IInstructorServicio _instServicio;
        private IHangarServicio _hanSrv;
        public EditarModel(IInstructorServicio instrv, IHangarServicio hanSrv){
            _instServicio=instrv;
            _hanSrv=hanSrv;
        }
    

        public void OnGet(int id)
        {
            var lista= _instServicio.MostrarTodos();
            InstructorEdit=lista.Where(x=>x.Id==id).First();
            HangaresLista=_hanSrv.MostrarHangares().Select(a=>
                                new SelectListItem{
                                    Value=a.Id.ToString(),
                                    Text=a.Detalle
                                }
                            ).ToList();
        }
        public IActionResult OnPost(){
            if(ModelState.IsValid){
                _instServicio.Modificar(InstructorEdit);
                return RedirectToPage("Listado");
            }
           else{
            return Page();
           }
        }
    }
}
    