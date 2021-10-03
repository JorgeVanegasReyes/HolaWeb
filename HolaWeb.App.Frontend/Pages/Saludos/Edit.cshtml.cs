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
    public class EditModel : PageModel /*esta clase modelo hace la comunicacion con la capa de persistencia */
    {
        private readonly IRepositorioSaludos repositorioSaludos;

        [BindProperty] /*para enlazar las paginas del formulario al modelo*/
        public Saludo Saludo {get;set;}

        public EditModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos=repositorioSaludos;
        }
        public IActionResult OnGet(int? saludoId) /* se coloca el ? para que sepa que HasValue a veces viene o no*/
        {
            if (saludoId.HasValue)  /*para el boton Adicionar*/
            {
            Saludo=repositorioSaludos.GetSaludoPorId(saludoId.Value);/*.value se le coloca porque a veces viene con valores o no*/
            }
            else
            {
                Saludo=new Saludo();
            }
            if(Saludo==null)  /*para el boton Editar*/
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
            
        }
        public IActionResult OnPost () /*se ejecuta cuando se va enviar inforcion al servidor*/
        {
            if (!ModelState.IsValid) /*Validacion -- el signo ! significa que si no es valido*/
            {
                return Page();
            }
            if(Saludo.Id>0)
            {
                Saludo= repositorioSaludos.Update(Saludo); /*para actualizar datos con el boton Edit*/
            }
            else
            {
                repositorioSaludos.Add(Saludo); /*para adicionar informacion nueva*/
            }
            Saludo= repositorioSaludos.Update (Saludo);
            return Page();
        }
    
    }
}