using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolaWeb.App.Persistencia.AppRepositorios;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
<<<<<<< HEAD
        //private string[] saludos= {"Nuevo cambio en GITHUB","Sdrasvitia", "Bon Jorno", "Bon Jour","Hello"}; //atributo de la clase
=======
    private string[] saludos= {"Nuevo cambio desde GITHUB a VS Code","Sdrasvitia", "Bon Jorno", "Bon Jour","Hello"}; //atributo de la clase
>>>>>>> 794d25bed44d3ca2f5e3015791c76ae6a02662a5

        //public List<string> ListaSaludos {get;set;} //propiedad de la clase
        private readonly IRepositorioSaludos repositorioSaludos;
        public IEnumerable<Saludo> Saludos {get;set;}

        public ListModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos=repositorioSaludos;
        }
        public void OnGet()
        {
            //ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(saludos);
            Saludos=repositorioSaludos.GetAll();

        }
    
    }
}
