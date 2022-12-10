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
         private IInstructorServicio _instrv;
        public CrearModel(IInstructorServicio srv){
            _instrv=srv;
        }
        public void OnGet()
        {
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
