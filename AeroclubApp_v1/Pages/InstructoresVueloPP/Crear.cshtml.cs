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
         private IInstructorServicio _prsrv;
        public CrearModel(IInstructorServicio srv){
            _prsrv=srv;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            _prsrv.Agregar(InstructorIng);
        }
        
    }
}
