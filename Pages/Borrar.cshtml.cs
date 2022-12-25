using CRUDAutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDAutos.Pages
{
    public class BorrarModel : PageModel
    {
        public ListadoAutos listado = new ListadoAutos();
       
        
        public BorrarModel(ListadoAutos listado)
        {
            this.listado = listado;
        }
        public void OnGet()
        {
           
            listado.borrarPublicacion(Convert.ToInt32(Request.Query["id"]));
            Response.Redirect("/");

        }
    }
}
