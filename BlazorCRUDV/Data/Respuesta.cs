using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDV.Data
{
    public class Respuesta<T>
    {
        public int Exito { get; set; } //Recibimos un entero para saber si se recibio algo por get
        public string Mensaje { get; set; } //Mandamos mensaje de error o exito
        public T Data { get; set; } //Se tendran datos

    }
}
