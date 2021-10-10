using System.Collections.Generic;
using HolaWeb.App.Dominio;
using System;
using System.Linq;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioSaludosMemoria:IRepositorioSaludos
    {
        List<Saludo> saludos;
 
        public RepositorioSaludosMemoria()
        {
            saludos= new List<Saludo>()
            /*{
                new Saludo{Id=1, EnEspanol="Buenos Dias", EnIngles="Good Morning", EnItaliano="Bungiorno"},
                new Saludo{Id=2, EnEspanol="Buenos Tardes", EnIngles="Good Afternoon", EnItaliano="Buon pomeriggio"},
                new Saludo{Id=3, EnEspanol="Buenos Noches", EnIngles="Good Evening", EnItaliano="Buona notte"}
            };*/
            {
                new Saludo{Id=1, EnEspanol="Alejandro Rodriguez", EnIngles="121484848", EnItaliano="320 9495873"},
                new Saludo{Id=2, EnEspanol="Sara Sanchez", EnIngles="75857733", EnItaliano="315 3484854"},
                new Saludo{Id=3, EnEspanol="Rocio Huertas", EnIngles="1343348829", EnItaliano="305 2495354"},
                new Saludo{Id=4, EnEspanol="Rocio Huertas", EnIngles="1343348829", EnItaliano="305 2495354"}
            };
        }
        public Saludo Add(Saludo nuevoSaludo)
        {
            nuevoSaludo.Id=saludos.Max(r=> r.Id)+1;
            saludos.Add(nuevoSaludo);
            return nuevoSaludo;
        }
        public IEnumerable<Saludo> GetAll()
        {
            return saludos;

        }
        
        public Saludo GetSaludoPorId(int saludoId)
        {
            return saludos.SingleOrDefault(s => s.Id == saludoId);
        }
        public Saludo Update(Saludo saludoActualizado)
        {
            var saludo=saludos.SingleOrDefault (r => r.Id== saludoActualizado.Id);
            if (saludo != null)
            {
                saludo.EnEspanol = saludoActualizado.EnEspanol;
                saludo.EnIngles = saludoActualizado.EnIngles;
                saludo.EnItaliano = saludoActualizado.EnItaliano;
            }
            return saludo;

        }

    }

}