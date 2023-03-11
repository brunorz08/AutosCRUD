namespace CRUDAutos.Models
{
    public class ListadoAutos
    {
        public List<Auto> lista = new List<Auto>()
       {
           new Auto()
           {
               modelo = "308",
               marca = "Peugeot",
               año = 2019,
               km = 56500,
               precio = 1275000,
               id = 0,
               url = "https://1.bp.blogspot.com/-zs6xvxYvc4c/XDaZ5TGz-AI/AAAAAAAAbos/72e--SEgZdknPjd6t02c4t9FjCwYC0X0QCLcBGAs/s1600/Peugeot-308-S-GT-2019-Argentina-%25282%2529.jpg"

           },

           new Auto()
           {
               modelo = "F40",
               marca = "Ferrari",
               año = 1997,
               km = 4880,
               precio = 1240000,
               id = 1,
               url = "https://f7432d8eadcf865aa9d9-9c672a3a4ecaaacdf2fee3b3e6fd2716.ssl.cf3.rackcdn.com/C2299/U7222/IMG_11418-large.jpg",

           },

           new Auto()
           {
               modelo = "Fit",
               marca = "Honda",
               año = 2022,
               km = 0,
               precio = 4250000,
               id = 2,
               url = "https://i0.wp.com/minutomotor.com.ar/wp-content/uploads/2018/09/HondaFitTest-05.jpg?resize=650%2C430&ssl=1",

           }



       };

        public void CrearPublicacion(Auto auto)
        {
            lista.Add(auto);
            auto.id = lista.IndexOf(auto);

        }

        public Auto obtenerUno(int id)
        {
            return lista[id];
        }

        public void borrarPublicacion(int id)
        {
            Auto autoaborrar = lista[id];
            lista.Remove(autoaborrar);
            Refresh();
        }

        public List<Auto> obtenerAutos()
        {
            return lista;
        }

        public void editarAuto(int id,Auto auto)
        {
            lista[id].marca = auto.marca;
            lista[id].modelo = auto.modelo;
            lista[id].año = auto.año;
            lista[id].km = auto.km;
            lista[id].precio = auto.precio;
            lista[id].url = auto.url;
        }

  
        public void Refresh()
        {
            foreach (var item in lista)
            {
                item.id = lista.IndexOf(item);
            }
        }


    }
}
