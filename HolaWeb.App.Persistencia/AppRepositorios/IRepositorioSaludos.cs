using System.Collections.Generic;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSaludos
    {
        IEnumerable<Saludo> GetAll();
        
        Saludo GetSaludoPorId(int saludoId); 

        Saludo Update(Saludo saludoActualizado); 

        Saludo Add(Saludo nuevoSaludo);/*va a retornar el saludo que se creo en Edit.cshtml.cs y se le da como parametro el saludo que se quiere adicionar*/
        /*luego vamos a implementarlo en RepositorioSaludosMemoria.cs* con la clase --public Saludo Add*/
    }
}