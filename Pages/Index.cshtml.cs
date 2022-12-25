using CRUDAutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDAutos.Pages
{
    public class IndexModel : PageModel
    {
        public ListadoAutos lista = new ListadoAutos();

        public IndexModel(ListadoAutos list)
        {
            lista = list;

        }


        public void OnGet()
        {
            
        }

        public void OnPost()
        {
       
        }
    }
}