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

        private IInstructorServicio _instServicio;
        public EditarModel(IInstructorServicio prosrv){
            _instServicio=prosrv;
        }
        public void OnGet(int id)
        {
            var lista= _instServicio.MostrarTodos();
            InstructorEdit=lista.Where(x=>x.Id==id).First();
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
    