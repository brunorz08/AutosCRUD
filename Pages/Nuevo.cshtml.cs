using CRUDAutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDAutos.Pages
{
    public class NuevoModel : PageModel

    {
        public ListadoAutos listado = new ListadoAutos();

        public NuevoModel(ListadoAutos lista)
        {
            listado = lista;
           
        }





        public void OnGet()
        {



        }

        public void OnPost()
        {
            listado.CrearPublicacion(new Auto()
            {
                marca = Request.Form["marca"],
                modelo = Request.Form["modelo"],
                año = Convert.ToInt32(Request.Form["año"]),
                km = Convert.ToInt32(Request.Form["km"]),
                precio = Convert.ToInt32(Request.Form["precio"]),
                url = Request.Form["url"],
                
            });

            Response.Redirect("/");
     }
    }
    
}
