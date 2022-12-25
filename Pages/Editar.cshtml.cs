using CRUDAutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDAutos.Pages
{
    public class EditarModel : PageModel
    {
        public Auto auto = new Auto();
        public ListadoAutos listado = new ListadoAutos();
        public EditarModel(ListadoAutos listado)
        {
            this.listado = listado;

        }
        public void OnGet()
        {
            auto = listado.obtenerUno(Convert.ToInt32(Request.Query["id"]));

        }

        public void OnPost()
        {
            listado.editarAuto(new Auto()
            {

                marca = Request.Form["marca"],
                modelo = Request.Form["modelo"],
                año = Convert.ToInt32(Request.Form["año"]),
                precio = Convert.ToInt32(Request.Form["precio"]),
                km = Convert.ToInt32(Request.Form["km"]),
                url = Request.Form["url"]

            }) ;

            Response.Redirect("/");

        }
    }
}
