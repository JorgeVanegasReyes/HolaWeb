using System;
using System.ComponentModel.DataAnnotations;

namespace HolaWeb.App.Dominio
{
    public class Saludo
    {
        public int Id {get;set;}
        
        [Required, StringLength(50)] /*validacion que agrega el-- using System.ComponentModel.DataAnnotations;*/
        /*antes de hacer las validaciones para los campos de Adicionar, se debe instalar un paquete en la capa de Dominio, dotnet add package System.ComponentModel.Annotations --version 5.0.0*/
        public String EnEspanol {get;set;}
        
        [Required, StringLength(50)]
        public String EnIngles {get;set;}
        
        [Required, StringLength(50)]
        public String EnItaliano {get;set;}
        

    }
}

