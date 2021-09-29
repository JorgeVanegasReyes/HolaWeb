using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
    private string[] saludos= {"Nuevo cambio desde GITHUB a VS Code","Sdrasvitia", "Bon Jorno", "Bon Jour","Hello"}; //atributo de la clase

    public List<string> ListaSaludos {get;set;} //propiedad de la clase

    
        public void OnGet()
        {
            ListaSaludos = new List<string>();
            ListaSaludos.AddRange(saludos);

        }
    
    }
}
